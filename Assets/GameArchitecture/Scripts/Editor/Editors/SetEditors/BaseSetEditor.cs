#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace GameArchitecture.Editor
{
    public class BaseSetEditor : UnityEditor.Editor
    {
        private SerializedProperty setTypeProperty;
        private SerializedProperty itemsProperty;

        private void OnEnable()
        {
            setTypeProperty = serializedObject.FindProperty("setType");
            itemsProperty = serializedObject.FindProperty("items");
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
                if ("runtimeItems" == property.propertyPath)
                {
                    if (setTypeProperty.intValue == 0)
                    {
                        continue;
                    }
                    else
                    {
                        using (new EditorGUI.DisabledScope(!Application.isPlaying))
                        {
                            if (Application.isPlaying)
                            {
                                EditorGUILayout.PropertyField(property, new GUIContent(property.displayName, property.tooltip));
                            }
                            else
                            {
                                bool itemsIsExpanded = itemsProperty.isExpanded;
                                itemsProperty.isExpanded = property.isExpanded;
                                EditorGUILayout.PropertyField(itemsProperty, new GUIContent(property.displayName, property.tooltip));
                                property.isExpanded = itemsProperty.isExpanded;
                                itemsProperty.isExpanded = itemsIsExpanded;
                            }
                        }
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