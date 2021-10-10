using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Values
{
    public abstract class BaseValue<T, E> : ScriptableObject where E : UnityEvent<T>
    {
        [SerializeField] protected ValueType valueType = ValueType.Variable;
        [SerializeField, Tooltip("Changes made to Value will be saved when exiting play mode.")] protected T value;
        [SerializeField, Tooltip("RuntimeValue is used during play mode, and not saved.")] private T runtimeValue; 
        [SerializeField, TextArea(4, 20)] private string description = "";

        [Tooltip("OnValueChanged can only reference scene-wide objects such as other ScriptableObjects.")]
        [Space, SerializeField] protected E onValueChanged;

        public T Value
        {
#if UNITY_EDITOR
            get { return runtimeValue; }
            set { SetValue(value, ref runtimeValue); }
#else
            get { return value; }
            set { SetValue(value, ref this.value); }
#endif
        }

        public E OnValueChanged { get { return onValueChanged; } set { onValueChanged = value; } }

        public string Description { get { return description; } }

        public ValueType DataType { get { return valueType; } }

        public static implicit operator T(BaseValue<T, E> reference)
        {
            return reference.Value;
        }

        private void SetValue(T newValue, ref T value)
        {
            if (valueType == ValueType.Constant)
            {
                Debug.LogError("Trying to modify " + GetType().Name + " " + name + " but it is set to Constant.");
                return;
            }

            bool valueChanged = !value.Equals(newValue);

            value = newValue;

            if (valueChanged)
            {
                onValueChanged?.Invoke(value);
            }
        }

        protected virtual void OnEnable()
        {
            //Prevents the asset from being unloaded when there are no scene references to it
            hideFlags = HideFlags.DontUnloadUnusedAsset;

#if UNITY_EDITOR
            //Initialize runtimeValue when running in the Editor
            runtimeValue = value;
#endif
        }
    }
}