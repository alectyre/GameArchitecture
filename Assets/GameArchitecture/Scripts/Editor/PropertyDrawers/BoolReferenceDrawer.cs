#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(BoolReference))]
    public class BoolReferenceDrawer : BaseReferenceDrawer { }
}
#endif