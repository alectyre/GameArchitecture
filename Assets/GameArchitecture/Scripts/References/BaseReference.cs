using UnityEngine;
using GameArchitecture.Values;

namespace GameArchitecture.References
{
    public abstract class BaseReference<T, GV> where GV : BaseValue<T>
    {
        [SerializeField] public bool UseConstant = true;
        [SerializeField] public T ConstantValue;
        [SerializeField] GV Variable = null;

        public T Value
        {
            get { return UseConstant ? ConstantValue : Variable.Value; }
        }

        public static implicit operator T(BaseReference<T, GV> reference)
        {
            return reference.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}