using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Values;

namespace GameArchitecture.References
{
    public abstract class BaseReference<T, V, E> where V : BaseValue<T, E> where E : UnityEvent<T>
    {
        [SerializeField] protected bool useConstant = false;
        [SerializeField] protected T constantValue;
        [SerializeField] protected V valueObject = null;

        public T Value
        {
            set { if (useConstant) { Debug.LogError("Trying to modify " + GetType().Name + " but it is set to Constant."); return; } this.valueObject.Value = value; }
            get { return useConstant ? constantValue : valueObject.Value; }
        }

        public static implicit operator T(BaseReference<T, V, E> reference)
        {
            return reference.Value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public E OnValueChanged
        {
            get { return valueObject.OnValueChanged; }
            set { valueObject.OnValueChanged = value; }
        }
    }
}