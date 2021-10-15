using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewTransformValue", menuName = "GameArchitecture/Values/TransformValue")]
    public class TransformValue : BaseValue<Transform, TransformUnityEvent> { }
}