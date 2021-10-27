using UnityEngine;
using GameArchitecture.Values;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.References
{
    [System.Serializable]
    public class ColorReference : BaseReference<Color, ColorValue, ColorUnityEvent> { }
}