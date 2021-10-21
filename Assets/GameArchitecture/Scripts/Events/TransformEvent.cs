using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewTransformEvent", menuName = "GameArchitecture/Events/TransformEvent")]
    public class TransformEvent : BaseEvent<Transform, TransformUnityEvent> { }
}