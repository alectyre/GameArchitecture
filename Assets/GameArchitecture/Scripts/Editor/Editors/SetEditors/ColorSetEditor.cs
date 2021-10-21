#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(ColorSet))]
    [CanEditMultipleObjects]
    public class ColorSetEditor : BaseSetEditor { }
}
#endif