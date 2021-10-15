using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class IntUnityEvent : UnityEvent<int> { }

    [CreateAssetMenu(fileName = "NewIntEvent", menuName = "GameArchitecture/Events/IntEvent")]
    public class IntEvent : BaseEvent<int, IntUnityEvent> { }
}