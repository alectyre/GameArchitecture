#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(ColorReference))]
    public class ColorReferenceDrawer : BaseReferenceDrawer { }
}
#endif