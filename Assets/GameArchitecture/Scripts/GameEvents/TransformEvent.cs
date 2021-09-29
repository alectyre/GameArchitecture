using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "NewTransformEvent", menuName = "GameArchitecture/Events/TransformEvent")]
    public class TransformEvent : BaseGameEvent<Transform> { }
}