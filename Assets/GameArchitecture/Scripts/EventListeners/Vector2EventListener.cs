using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityVector2Event : UnityEvent<Vector2> { }

    public class Vector2EventListener : BaseEventListener<Vector2, Vector2Event, UnityVector2Event> { }
}