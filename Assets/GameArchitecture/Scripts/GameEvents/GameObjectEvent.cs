using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "NewGameObjectEvent", menuName = "GameArchitecture/Events/GameObjectEvent")]
    public class GameObjectEvent : BaseGameEvent<GameObject> { }
}