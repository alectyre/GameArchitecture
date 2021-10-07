using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityVector3Event : UnityEvent<Vector3> { }

    public class Vector3EventListener : BaseEventListener<Vector3, Vector3Event, UnityVector3Event> { }
}