#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(FloatSet))]
    [CanEditMultipleObjects]
    public class FloatSetEditor : BaseSetEditor { }
}
#endif