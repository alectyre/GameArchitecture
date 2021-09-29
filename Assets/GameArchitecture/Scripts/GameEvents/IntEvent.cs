using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "NewIntEvent", menuName = "GameArchitecture/Events/IntEvent")]
    public class IntEvent : BaseGameEvent<int> { }
}