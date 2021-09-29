using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityTransformEvent : UnityEvent<Transform> { }

    public class TransformEventListener : BaseGameEventListener<Transform, TransformEvent, UnityTransformEvent> { }
}