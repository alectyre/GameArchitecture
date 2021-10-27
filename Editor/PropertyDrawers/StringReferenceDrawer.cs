#if UNITY_EDITOR
using UnityEditor;
using GameArchitecture.References;

namespace GameArchitecture.Editor
{
    [CustomPropertyDrawer(typeof(StringReference))]
    public class StringReferenceDrawer : BaseReferenceDrawer { }
}
#endif