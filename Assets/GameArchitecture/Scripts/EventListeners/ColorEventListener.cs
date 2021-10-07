using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityColorEvent : UnityEvent<Color> { }

    public class ColorEventListener : BaseEventListener<Color, ColorEvent, UnityColorEvent> { }
}