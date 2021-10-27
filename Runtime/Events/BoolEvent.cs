using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewBoolEvent", menuName = "GameArchitecture/Events/BoolEvent")]
    public class BoolEvent : BaseEvent<bool, BoolUnityEvent> { }
}