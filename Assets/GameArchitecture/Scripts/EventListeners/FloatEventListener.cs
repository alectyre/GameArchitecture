using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityFloatEvent : UnityEvent<float> { }

    public class FloatEventListener : BaseEventListener<float, FloatEvent, UnityFloatEvent> { }
}