#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.Collections;

namespace GameArchitecture.Editor
{
    [CustomEditor(typeof(GameObjectSet))]
    [CanEditMultipleObjects]
    public class GameObjectSetEditor : BaseSetEditor { }
}
#endif