using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "NewStringEvent", menuName = "GameArchitecture/Events/StringEvent")]
    public class StringEvent : BaseGameEvent<string> { }
}