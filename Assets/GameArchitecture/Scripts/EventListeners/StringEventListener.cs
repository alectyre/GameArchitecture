using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityStringEvent : UnityEvent<string> { }

    public class StringEventListener : BaseEventListener<string, StringEvent, UnityStringEvent> { }
}