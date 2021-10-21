#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(StringSet))]
    [CanEditMultipleObjects]
    public class StringSetEditor : BaseSetEditor { }
}
#endif