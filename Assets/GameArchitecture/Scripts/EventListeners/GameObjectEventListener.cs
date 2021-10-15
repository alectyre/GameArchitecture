using UnityEngine;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    public class GameObjectEventListener : BaseEventListener<GameObject, GameObjectEvent, GameObjectUnityEvent> { }
}