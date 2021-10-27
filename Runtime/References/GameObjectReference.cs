using UnityEngine;
using GameArchitecture.Values;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.References
{
    [System.Serializable]
    public class GameObjectReference : BaseReference<GameObject, GameObjectValue, GameObjectUnityEvent> { }
}