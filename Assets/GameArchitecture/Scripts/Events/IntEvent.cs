using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewIntEvent", menuName = "GameArchitecture/Events/IntEvent")]
    public class IntEvent : BaseEvent<int, IntUnityEvent> { }
}