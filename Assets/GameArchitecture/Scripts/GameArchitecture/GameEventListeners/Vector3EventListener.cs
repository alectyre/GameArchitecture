using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityVector3Event : UnityEvent<Vector3> { }

    public class Vector3EventListener : BaseGameEventListener<Vector3, Vector3Event, UnityVector3Event> { }
}