#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(Vector2Reference))]
    public class Vector2ReferenceDrawer : BaseReferenceDrawer { }
}
#endif