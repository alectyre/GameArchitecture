using UnityEngine;
using GameArchitecture.GameVariables;

namespace GameArchitecture.GameReferences
{
    public abstract class BaseGameReference<T, GV> where GV : BaseGameVariable<T>
    {
        [SerializeField] public bool UseConstant = true;
        [SerializeField] public T ConstantValue;
        [SerializeField] GV Variable = null;

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator T(BaseGameReference<T, GV> reference)
        {
            return reference.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}