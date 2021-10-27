#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(IntReference))]
    public class IntReferenceDrawer : BaseReferenceDrawer { }
}
#endif