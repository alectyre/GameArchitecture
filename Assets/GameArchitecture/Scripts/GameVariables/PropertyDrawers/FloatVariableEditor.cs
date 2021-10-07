#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.GameVariables;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(FloatVariable))]
    [CanEditMultipleObjects]
    public class FloatVariableEditor : BaseVariableEditor { }
}
#endif