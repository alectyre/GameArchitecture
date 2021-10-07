using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityTransformEvent : UnityEvent<Transform> { }

    public class TransformEventListener : BaseEventListener<Transform, TransformEvent, UnityTransformEvent> { }
}