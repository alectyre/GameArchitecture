using UnityEngine;
using GameArchitecture.Values;
using System;

namespace GameArchitecture.References
{
    public abstract class BaseReference<T, V> where V : BaseValue<T>
    {
        [SerializeField] protected bool useConstant = false;
        [SerializeField] protected T constantValue;
        [SerializeField] protected V value = null;

        public T Value
        {
            set { if (useConstant) { Debug.LogError("Trying to modify " + GetType().Name + " but it is set to Constant."); return; } this.value.Value = value; }
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

        public void AddListenerOnValueChanged(Action<T> action)
        {
            value.AddListenerOnValueChanged(action);
        }

        public void RemoveListenerOnValueChanged(Action<T> action)
        {
            value.RemoveListenerOnValueChanged(action);
        }
    }
}