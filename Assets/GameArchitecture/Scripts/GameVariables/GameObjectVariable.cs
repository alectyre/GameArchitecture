using UnityEngine;

namespace GameArchitecture.GameVariables
{
    [CreateAssetMenu(fileName = "NewGameObjectVariable", menuName = "GameArchitecture/Variables/GameObjectVariable")]
    public class GameObjectVariable : BaseGameVariable<GameObject> { }
}