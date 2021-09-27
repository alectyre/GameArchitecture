using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityVoidEvent : UnityEvent<Void> { }

    public class VoidEventListener : BaseGameEventListener<Void, VoidEvent, UnityVoidEvent> { }
}