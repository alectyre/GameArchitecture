using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewGameObjectEvent", menuName = "GameArchitecture/Events/GameObjectEvent")]
    public class GameObjectEvent : BaseEvent<GameObject, GameObjectUnityEvent> { }
}