using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class Vector3UnityEvent : UnityEvent<Vector3> { }

    [CreateAssetMenu(fileName = "NewVector3Event", menuName = "GameArchitecture/Events/Vector3Event")]
    public class Vector3Event : BaseEvent<Vector3, Vector3UnityEvent> { }
}