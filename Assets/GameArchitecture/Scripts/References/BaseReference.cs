using UnityEngine;
using GameArchitecture.Values;

namespace GameArchitecture.References
{
    public abstract class BaseReference<T, V> where V : BaseValue<T>
    {
        [SerializeField] public bool useConstant = false;
        [SerializeField] public T constantValue;
        [SerializeField] private V value = null;

        public T Value
        {
            set { if (useConstant) return; this.value.Value = value; }
            get { return useConstant ? constantValue : value.Value; }
        }

        public static implicit operator T(BaseReference<T, V> reference)
        {
            return reference.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}