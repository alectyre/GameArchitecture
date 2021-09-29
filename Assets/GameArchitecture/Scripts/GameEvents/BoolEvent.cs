using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "NewBoolEvent", menuName = "GameArchitecture/Events/BoolEvent")]
    public class BoolEvent : BaseGameEvent<bool> { }
}