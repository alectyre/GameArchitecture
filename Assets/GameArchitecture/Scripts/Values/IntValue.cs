using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class IntValueEvent : UnityEvent<int> { }

    [CreateAssetMenu(fileName = "NewIntValue", menuName = "GameArchitecture/Values/IntValue")]
    public class IntValue : BaseValue<int, IntValueEvent> { }
}