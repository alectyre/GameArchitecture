using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "NewColorEvent", menuName = "GameArchitecture/Events/ColorEvent")]
    public class ColorEvent : BaseGameEvent<Color> { }
}