using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewIntValue", menuName = "GameArchitecture/Values/IntValue")]
    public class IntValue : BaseValue<int, IntUnityEvent> { }
}