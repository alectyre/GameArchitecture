using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewVector3Value", menuName = "GameArchitecture/Values/Vector3Value")]
    public class Vector3Value : BaseValue<Vector3, Vector3UnityEvent> { }
}