using UnityEngine;
using System.IO;

namespace GameArchitecture.GameVariables
{
    [CreateAssetMenu(fileName = "NewFloatVariable", menuName = "GameArchitecture/Variables/FloatVariable")]
    public class FloatVariable : BaseGameVariable<float> { }
}