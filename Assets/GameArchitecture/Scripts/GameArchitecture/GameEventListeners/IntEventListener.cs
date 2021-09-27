using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityIntEvent : UnityEvent<int> { }

    public class IntEventListener : BaseGameEventListener<int, IntEvent, UnityIntEvent> { }
}