using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class TransformUnityEvent : UnityEvent<Transform> { }

    [CreateAssetMenu(fileName = "NewTransformEvent", menuName = "GameArchitecture/Events/TransformEvent")]
    public class TransformEvent : BaseEvent<Transform, TransformUnityEvent> { }
}