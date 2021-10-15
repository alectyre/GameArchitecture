using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class StringUnityEvent : UnityEvent<string> { }

    [CreateAssetMenu(fileName = "NewStringEvent", menuName = "GameArchitecture/Events/StringEvent")]
    public class StringEvent : BaseEvent<string, StringUnityEvent> { }
}