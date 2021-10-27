using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewGameObjectValue", menuName = "GameArchitecture/Values/GameObjectValue")]
    public class GameObjectValue : BaseValue<GameObject, GameObjectUnityEvent> { }
}