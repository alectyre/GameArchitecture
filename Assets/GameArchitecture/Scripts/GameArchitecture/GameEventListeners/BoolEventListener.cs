using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityBboolEvent : UnityEvent<bool> { }

    public class BoolEventListener : BaseGameEventListener<bool, BoolEvent, UnityBboolEvent> { }
}