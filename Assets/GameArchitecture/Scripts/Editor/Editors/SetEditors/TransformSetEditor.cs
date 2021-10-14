#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(TransformSet))]
    [CanEditMultipleObjects]
    public class TransformSetEditor : BaseSetEditor { }
}
#endif