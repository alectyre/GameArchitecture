using UnityEngine;
using GameArchitecture.Events;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.EventListeners
{
    public class ColorEventListener : BaseEventListener<Color, ColorEvent, ColorUnityEvent> { }
}