using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewColorEvent", menuName = "GameArchitecture/Events/ColorEvent")]
    public class ColorEvent : BaseEvent<Color, ColorUnityEvent> { }
}