using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class GameObjectUnityEvent : UnityEvent<GameObject> { }

    [CreateAssetMenu(fileName = "NewGameObjectEvent", menuName = "GameArchitecture/Events/GameObjectEvent")]
    public class GameObjectEvent : BaseEvent<GameObject, GameObjectUnityEvent> { }
}