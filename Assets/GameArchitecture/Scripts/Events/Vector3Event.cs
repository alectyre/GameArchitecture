using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewVector3Event", menuName = "GameArchitecture/Events/Vector3Event")]
    public class Vector3Event : BaseEvent<Vector3, Vector3UnityEvent> { }
}