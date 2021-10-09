using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class ColorValueEvent : UnityEvent<Color> { }

    [CreateAssetMenu(fileName = "NewColorValue", menuName = "GameArchitecture/Values/ColorValue")]
    public class ColorValue : BaseValue<Color, ColorValueEvent> { }
}