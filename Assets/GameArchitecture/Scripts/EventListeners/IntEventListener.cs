using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityIntEvent : UnityEvent<int> { }

    public class IntEventListener : BaseEventListener<int, IntEvent, UnityIntEvent> { }
}