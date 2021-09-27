using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "New GameObjectEvent", menuName = "GameArchitecture/Events/GameObjectEvent")]
    public class GameObjectEvent : BaseGameEvent<GameObject> { }
}