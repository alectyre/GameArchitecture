using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewFloatValue", menuName = "GameArchitecture/Values/FloatValue")]
    public class FloatValue : BaseValue<float, FloatUnityEvent> { }
}