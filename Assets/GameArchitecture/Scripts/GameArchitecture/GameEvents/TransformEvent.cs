using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [CreateAssetMenu(fileName = "New TransformEvent", menuName = "GameArchitecture/Events/TransformEvent")]
    public class TransformEvent : BaseGameEvent<Transform> { }
}