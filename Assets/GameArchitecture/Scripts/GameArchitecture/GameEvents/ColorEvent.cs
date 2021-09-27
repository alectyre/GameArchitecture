using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "New ColorEvent", menuName = "GameArchitecture/Events/ColorEvent")]
    public class ColorEvent : BaseGameEvent<Color> { }
}