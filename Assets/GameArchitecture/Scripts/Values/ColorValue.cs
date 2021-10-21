using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewColorValue", menuName = "GameArchitecture/Values/ColorValue")]
    public class ColorValue : BaseValue<Color, ColorUnityEvent> { }
}