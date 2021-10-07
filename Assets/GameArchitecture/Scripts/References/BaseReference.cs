using UnityEngine;
using GameArchitecture.Values;

namespace GameArchitecture.References
{
    public abstract class BaseReference<T, V> where V : BaseValue<T>
    {
        [SerializeField] private bool useConstant = false;
        [SerializeField] private T constantValue;
        [SerializeField] private V value = null;

        public T Value
        {
            set { if (useConstant) { Debug.LogError("Trying to modify " + this.GetType().Name + " but it is set to Constant."); return; } this.value.Value = value; }
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