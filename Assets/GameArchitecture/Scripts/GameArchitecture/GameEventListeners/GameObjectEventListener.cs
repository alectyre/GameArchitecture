using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    [System.Serializable] public class UnityGameObjectEvent : UnityEvent<GameObject> { }

    public class GameObjectEventListener : BaseGameEventListener<GameObject, GameObjectEvent, UnityGameObjectEvent> { }
}