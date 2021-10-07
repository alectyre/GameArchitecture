#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.GameReferences;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(FloatReference))]
    public class FloatReferenceDrawer : BaseReferenceDrawer { }
}
#endif