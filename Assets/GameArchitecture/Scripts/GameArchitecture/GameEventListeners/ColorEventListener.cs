using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityColorEvent : UnityEvent<Color> { }

    public class ColorEventListener : BaseGameEventListener<Color, ColorEvent, UnityColorEvent> { }
}