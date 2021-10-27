#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(Vector3Set))]
    [CanEditMultipleObjects]
    public class Vector3SetEditor : BaseSetEditor { }
}
#endif