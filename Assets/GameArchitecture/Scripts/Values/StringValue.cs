using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class StringValueEvent : UnityEvent<string> { }

    [CreateAssetMenu(fileName = "NewStringValue", menuName = "GameArchitecture/Values/StringValue")]
    public class StringValue : BaseValue<string, StringValueEvent> { }
}