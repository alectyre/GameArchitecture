using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewStringValue", menuName = "GameArchitecture/Values/StringValue")]
    public class StringValue : BaseValue<string, StringUnityEvent> { }
}