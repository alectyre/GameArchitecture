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

    private GUIStyle buttonStyle;
    private const int lineHeight = 13;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.String)
        {
            if (buttonStyle == null)
            {
                buttonStyle = new GUIStyle(GUI.skin.GetStyle("iconButton"));
            }

            label = EditorGUI.BeginProperty(position, label, property);
            Rect buttonRect = EditorGUI.PrefixLabel(position, label);
            buttonRect.width = EditorGUIUtility.singleLineHeight;
            buttonRect.height = EditorGUIUtility.singleLineHeight;

            EditorGUI.BeginChangeCheck();

            GUIContent image = isLocked ? EditorGUIUtility.IconContent("IN LockButton on") : EditorGUIUtility.IconContent("IN LockButton");
            if(GUI.Button(buttonRect, image, buttonStyle))
            {
                isLocked = !isLocked;
            }

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