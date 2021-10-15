using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class Vector2UnityEvent : UnityEvent<Vector2> { }

    [CreateAssetMenu(fileName = "NewVector2Event", menuName = "GameArchitecture/Events/Vector2Event")]
    public class Vector2Event : BaseEvent<Vector2, Vector2UnityEvent> { }
}