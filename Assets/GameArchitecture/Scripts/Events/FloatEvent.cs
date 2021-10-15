using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewFloatEvent", menuName = "GameArchitecture/Events/FloatEvent")]
    public class FloatEvent : BaseEvent<float, FloatUnityEvent> { }
}