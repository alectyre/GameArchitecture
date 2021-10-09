using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class FloatValueEvent : UnityEvent<float> { }

    [CreateAssetMenu(fileName = "NewFloatValue", menuName = "GameArchitecture/Values/FloatValue")]
    public class FloatValue : BaseValue<float, FloatValueEvent> { }
}