#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(Vector3Reference))]
    public class Vector3ReferenceDrawer : BaseReferenceDrawer { }
}
#endif