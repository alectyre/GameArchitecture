using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class Vector3ValueEvent : UnityEvent<Vector3> { }

    [CreateAssetMenu(fileName = "NewVector3Value", menuName = "GameArchitecture/Values/Vector3Value")]
    public class Vector3Value : BaseValue<Vector3, Vector3ValueEvent> { }
}