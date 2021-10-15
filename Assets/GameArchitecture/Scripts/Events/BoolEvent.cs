using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class BoolUnityEvent : UnityEvent<bool> { }

    [CreateAssetMenu(fileName = "NewBoolEvent", menuName = "GameArchitecture/Events/BoolEvent")]
    public class BoolEvent : BaseEvent<bool, BoolUnityEvent> { }
}