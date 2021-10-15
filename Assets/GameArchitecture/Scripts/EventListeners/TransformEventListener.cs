using UnityEngine;
using GameArchitecture.Events;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.EventListeners
{
    public class TransformEventListener : BaseEventListener<Transform, TransformEvent, TransformUnityEvent> { }
}