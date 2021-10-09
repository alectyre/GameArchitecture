using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class GameObjectValueEvent : UnityEvent<GameObject> { }

    [CreateAssetMenu(fileName = "NewGameObjectValue", menuName = "GameArchitecture/Values/GameObjectValue")]
    public class GameObjectValue : BaseValue<GameObject, GameObjectValueEvent> { }
}