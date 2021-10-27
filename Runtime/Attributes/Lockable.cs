using System;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
public sealed class LockableAttribute : PropertyAttribute { }


#if UNITY_EDITOR
[CustomPropertyDrawer(typeof(LockableAttribute))]
public sealed class PopPlatformAttributePropertyDrawer : PropertyDrawer
{
    public bool isLocked = true;

    private GUIStyle buttonStyle;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (buttonStyle == null)
        {
            buttonStyle = new GUIStyle(GUI.skin.GetStyle("iconButton"));
        }

        label = EditorGUI.BeginProperty(position, label, property);
        position = EditorGUI.PrefixLabel(position, label);

        EditorGUI.BeginChangeCheck();

        // Calculate rect for configuration button
        Rect buttonRect = new Rect(position);
        buttonRect.yMin += buttonStyle.margin.top;
        buttonRect.width = buttonStyle.fixedWidth + buttonStyle.margin.right;
        position.xMin = buttonRect.xMax;

        // Store old indent level and set it to 0, the PrefixLabel takes care of it
        int indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;

        GUIContent image = isLocked ? EditorGUIUtility.IconContent("IN LockButton on") : EditorGUIUtility.IconContent("IN LockButton");
        if (GUI.Button(buttonRect, image, buttonStyle))
        {
            isLocked = !isLocked;
        }
        
        using (new EditorGUI.DisabledScope(isLocked))
        {
            EditorGUI.PropertyField(position, property, GUIContent.none);
        }

        if (EditorGUI.EndChangeCheck())
            property.serializedObject.ApplyModifiedProperties();

        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}
#endif