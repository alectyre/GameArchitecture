#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(IntSet))]
    [CanEditMultipleObjects]
    public class IntSetEditor : BaseSetEditor { }
}
#endif