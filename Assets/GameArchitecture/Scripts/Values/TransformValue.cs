using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    [System.Serializable] public class TransformValueEvent : UnityEvent<Transform> { }


    [CreateAssetMenu(fileName = "NewTransformValue", menuName = "GameArchitecture/Values/TransformValue")]
    public class TransformValue : BaseValue<Transform, TransformValueEvent> { }
}