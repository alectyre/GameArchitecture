using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityVoidEvent : UnityEvent<Void> { }

    public class VoidEventListener : BaseEventListener<Void, VoidEvent, UnityVoidEvent> { }
}