using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class FloatUnityevent : UnityEvent<float> { }

    [CreateAssetMenu(fileName = "NewFloatEvent", menuName = "GameArchitecture/Events/FloatEvent")]
    public class FloatEvent : BaseEvent<float, FloatUnityevent> { }
}