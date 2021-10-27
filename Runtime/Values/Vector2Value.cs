using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Values
{
    [CreateAssetMenu(fileName = "NewVector2Value", menuName = "GameArchitecture/Values/Vector2Value")]
    public class Vector2Value : BaseValue<Vector2, Vector2UnityEvent> { }
}