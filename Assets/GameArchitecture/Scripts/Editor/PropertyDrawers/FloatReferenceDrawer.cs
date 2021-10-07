#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(FloatReference))]
    public class FloatReferenceDrawer : BaseReferenceDrawer { }
}
#endif