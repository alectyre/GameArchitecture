#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(TransformReference))]
    public class TransformReferenceDrawer : BaseReferenceDrawer { }
}
#endif