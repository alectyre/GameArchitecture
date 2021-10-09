#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace GameArchitecture.Editor
{
    public class BaseValueEditor : UnityEditor.Editor
    {
        private SerializedProperty valueTypeProperty;
        private SerializedProperty valueProperty;

        private void OnEnable()
        {
            valueTypeProperty = serializedObject.FindProperty("valueType");
            valueProperty = serializedObject.FindProperty("value");
        }

        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            serializedObject.UpdateIfRequiredOrScript();

            // Loop through properties and create one field (including children) for each top level property.
            SerializedProperty property = serializedObject.GetIterator();
            bool expanded = true;
            while (property.NextVisible(expanded))
            {
                if ("runtimeValue" == property.propertyPath)
                {
                    if (valueTypeProperty.intValue == 0)
                    {
                        continue;
                    }
                    else using (new EditorGUI.DisabledScope(!Application.isPlaying))
                    {
                        property.floatValue = EditorGUILayout.FloatField(new GUIContent(property.displayName, property.tooltip), valueProperty.floatValue);
                    }
                }
                else using (new EditorGUI.DisabledScope( "m_Script" == property.propertyPath))
                {
                    EditorGUILayout.PropertyField(property, true);
                }
                expanded = false;
            }

            serializedObject.ApplyModifiedProperties();
            EditorGUI.EndChangeCheck();
        }
    }
}
#endif