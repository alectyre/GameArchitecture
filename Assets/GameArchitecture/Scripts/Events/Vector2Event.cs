using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewVector2Event", menuName = "GameArchitecture/Events/Vector2Event")]
    public class Vector2Event : BaseEvent<Vector2, Vector2UnityEvent> { }
}