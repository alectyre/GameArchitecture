#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace GameArchitecture.Editor
{
    public class BaseValueEditor : UnityEditor.Editor
    {
        SerializedProperty scriptProperty;
        SerializedProperty valueTypeProperty;
        SerializedProperty valueProperty;
        SerializedProperty runtimeValueProperty;

        void OnEnable()
        {
            scriptProperty = serializedObject.FindProperty("m_Script");
            valueTypeProperty = serializedObject.FindProperty("valueType");
            valueProperty = serializedObject.FindProperty("value");
            runtimeValueProperty = serializedObject.FindProperty("runtimeValue");
        }

        public override void OnInspectorGUI()
        {
            GUI.enabled = false;
            EditorGUILayout.PropertyField(scriptProperty);
            GUI.enabled = true;

            serializedObject.Update();
            EditorGUILayout.PropertyField(valueTypeProperty);
            EditorGUILayout.PropertyField(valueProperty);
            if (valueTypeProperty.intValue != 0)
            {
                GUI.enabled = Application.isPlaying;
                EditorGUILayout.PropertyField(runtimeValueProperty);
                GUI.enabled = true;
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
#endif