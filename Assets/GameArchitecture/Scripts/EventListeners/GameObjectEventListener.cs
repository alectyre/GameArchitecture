using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    [System.Serializable] public class UnityGameObjectEvent : UnityEvent<GameObject> { }

    public class GameObjectEventListener : BaseEventListener<GameObject, GameObjectEvent, UnityGameObjectEvent> { }
}