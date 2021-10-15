using UnityEngine;
using GameArchitecture.Events;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.EventListeners
{
    public class GameObjectEventListener : BaseEventListener<GameObject, GameObjectEvent, GameObjectUnityEvent> { }
}