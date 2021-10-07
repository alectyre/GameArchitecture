using UnityEngine;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewStringEvent", menuName = "GameArchitecture/Events/StringEvent")]
    public class StringEvent : BaseEvent<string> { }
}