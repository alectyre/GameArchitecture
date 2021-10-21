using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewBoolValue", menuName = "GameArchitecture/Values/BoolValue")]
    public class BoolValue : BaseValue<bool, BoolUnityEvent> { }
}