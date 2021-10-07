using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityStringEvent : UnityEvent<string> { }

    public class StringEventListener : BaseGameEventListener<string, StringEvent, UnityStringEvent> { }
}