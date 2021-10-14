#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Values;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(FloatValue))]
    [CanEditMultipleObjects]
    public class FloatValueEditor : BaseValueEditor { }
}
#endif