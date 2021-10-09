using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class BoolValueEvent : UnityEvent<bool> { }


    [CreateAssetMenu(fileName = "NewBoolValue", menuName = "GameArchitecture/Values/BoolValue")]
    public class BoolValue : BaseValue<bool, BoolValueEvent> { }
}