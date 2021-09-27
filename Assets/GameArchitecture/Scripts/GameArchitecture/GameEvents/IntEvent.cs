using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "New IntEvent", menuName = "GameArchitecture/Events/IntEvent")]
    public class IntEvent : BaseGameEvent<int> { }
}