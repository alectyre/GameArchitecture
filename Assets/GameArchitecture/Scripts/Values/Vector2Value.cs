using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class Vector2ValueEvent : UnityEvent<Vector2> { }

    [CreateAssetMenu(fileName = "NewVector2Value", menuName = "GameArchitecture/Values/Vector2Value")]
    public class Vector2Value : BaseValue<Vector2, Vector2ValueEvent> { }
}