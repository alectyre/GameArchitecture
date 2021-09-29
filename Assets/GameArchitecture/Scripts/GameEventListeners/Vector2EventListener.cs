using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityVector2Event : UnityEvent<Vector2> { }

    public class Vector2EventListener : BaseGameEventListener<Vector2, Vector2Event, UnityVector2Event> { }
}