#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(GameObjectReference))]
    public class GameObjectReferenceDrawer : BaseReferenceDrawer { }
}
#endif