using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "New BoolEvent", menuName = "GameArchitecture/Events/BoolEvent")]
    public class BoolEvent : BaseGameEvent<bool> { }
}