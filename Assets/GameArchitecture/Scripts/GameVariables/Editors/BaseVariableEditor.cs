#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace GameArchitecture.Editor
{
    public class BaseVariableEditor : UnityEditor.Editor
    {
        SerializedProperty scriptProperty;
        SerializedProperty dataTypeProperty;
        SerializedProperty valueProperty;
        SerializedProperty runtimeValueProperty;

        void OnEnable()
        {
            scriptProperty = serializedObject.FindProperty("m_Script");
            dataTypeProperty = serializedObject.FindProperty("dataType");
            valueProperty = serializedObject.FindProperty("value");
            runtimeValueProperty = serializedObject.FindProperty("runtimeValue");
        }

        public override void OnInspectorGUI()
        {
            GUI.enabled = false;
            EditorGUILayout.PropertyField(scriptProperty);
            GUI.enabled = true;

            serializedObject.Update();
            EditorGUILayout.PropertyField(dataTypeProperty);
            EditorGUILayout.PropertyField(valueProperty);
            if (dataTypeProperty.intValue != 0)
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