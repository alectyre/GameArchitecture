using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityBboolEvent : UnityEvent<bool> { }

    public class BoolEventListener : BaseEventListener<bool, BoolEvent, UnityBboolEvent> { }
}