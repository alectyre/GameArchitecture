using System;
using UnityEngine;
using Object = UnityEngine.Object;
#if UNITY_EDITOR
using UnityEditor;
#endif

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public sealed class LockableTextAreaAttribute : PropertyAttribute
{
    public int minLines;
    public int maxLines;

    public LockableTextAreaAttribute(int minLines, int maxLines)
    {
        this.minLines = minLines;
        this.maxLines = maxLines;
    }
}

[CustomPropertyDrawer(typeof(LockableTextAreaAttribute))]
public sealed class LockableTextAreaDrawer : PropertyDrawer
{   
    public bool isLocked = true;

    private readonly string[] popupOptions = { "Locked", "Unlocked" };

    /// <summary> Cached style to use to draw the popup button. </summary>
    private GUIStyle popupStyle;

    private const int lineHeight = 13;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.String)
        {
            if (popupStyle == null)
            {
                popupStyle = new GUIStyle(GUI.skin.GetStyle("PaneOptions"))
                {
                    imagePosition = ImagePosition.ImageOnly
                };
            }

            label = EditorGUI.BeginProperty(position, label, property);
            Rect buttonRect = EditorGUI.PrefixLabel(position, label);
            buttonRect.yMin += popupStyle.margin.top;
            buttonRect.width = (popupStyle.fixedWidth + popupStyle.margin.right) * 2;
            buttonRect.height = EditorGUIUtility.singleLineHeight;
            
            EditorGUI.BeginChangeCheck();

            int result = EditorGUI.Popup(buttonRect, isLocked ? 0 : 1, popupOptions, popupStyle);
            isLocked = result == 0;

            buttonRect.x += buttonRect.width * 0.5f;
            EditorGUI.LabelField(buttonRect, isLocked ? EditorGUIUtility.IconContent("IN LockButton on") : EditorGUIUtility.IconContent("IN LockButton"));

            string newValue = "";

            using (new EditorGUI.DisabledScope(isLocked))
            {
                position.yMin += EditorGUIUtility.singleLineHeight;
                newValue = EditorGUI.TextArea(position, property.stringValue, EditorStyles.textArea);     
            }

            if (EditorGUI.EndChangeCheck())
            {
                property.serializedObject.ApplyModifiedProperties();
                property.stringValue = newValue;
            }

            EditorGUI.EndProperty();
        }
        else
            EditorGUI.LabelField(position, label.text, "Use TextAreaDrawer with string.");
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        LockableTextAreaAttribute textAreaAttribute = attribute as LockableTextAreaAttribute;
        string text = property.stringValue;

        float fullTextHeight = EditorStyles.textArea.CalcHeight(new GUIContent(text), EditorGUIUtility.currentViewWidth);
        int lines = Mathf.CeilToInt(fullTextHeight / lineHeight);

        lines = Mathf.Clamp(lines, textAreaAttribute.minLines, textAreaAttribute.maxLines);

        return EditorGUIUtility.singleLineHeight // header
            + EditorGUIUtility.singleLineHeight // first line
            + (lines - 1) * lineHeight; // remaining lines
    }
}