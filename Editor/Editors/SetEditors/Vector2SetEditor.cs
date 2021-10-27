#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(Vector2Set))]
    [CanEditMultipleObjects]
    public class Vector2SetEditor : BaseSetEditor { }
}
#endif