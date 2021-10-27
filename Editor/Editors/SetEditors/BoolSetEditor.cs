#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(BoolSet))]
    [CanEditMultipleObjects]
    public class BoolSetEditor : BaseSetEditor { }
}
#endif