using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityFloatEvent : UnityEvent<float> { }

    public class FloatEventListener : BaseGameEventListener<float, FloatEvent, UnityFloatEvent> { }
}