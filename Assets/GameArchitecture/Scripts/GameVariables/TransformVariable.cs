using UnityEngine;

namespace GameArchitecture.GameVariables
{
    [CreateAssetMenu(fileName = "NewTransformVariable", menuName = "GameArchitecture/Variables/TransformVariable")]
    public class TransformVariable : BaseGameVariable<Transform> { }
}