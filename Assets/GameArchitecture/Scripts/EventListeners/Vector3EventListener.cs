using UnityEngine;
using GameArchitecture.Events;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.EventListeners
{
    public class Vector3EventListener : BaseEventListener<Vector3, Vector3Event, Vector3UnityEvent> { }
}