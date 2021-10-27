using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewStringEvent", menuName = "GameArchitecture/Events/StringEvent")]
    public class StringEvent : BaseEvent<string, StringUnityEvent> { }
}