using UnityEngine;

namespace GameArchitecture.Values
{
    public abstract class BaseValue<T> : ScriptableObject
    {
        [SerializeField] protected T value;
        [SerializeField] protected ValueType valueType = ValueType.Variable;
        [SerializeField, TextArea(4, 20)] private string description = "";
        
#if UNITY_EDITOR
        /// <summary>
        /// Value is copied to runtimeValue when running in the editor to avoid overwriting seralized value.
        /// </summary>
        [SerializeField]  private T runtimeValue;
#endif

        public T Value
        {
#if UNITY_EDITOR
            get { return runtimeValue; }
            set { if (valueType == ValueType.Constant) { Debug.LogError("Trying to modify " + GetType().Name + " " + name + " but it is set to Constant."); return; } runtimeValue = value; }
#else
            get { return value; }
            set { if (dataType == DataType.Constant) return; this.value = value; }
#endif
        }

        public string Description { get { return description; } }

        public ValueType DataType { get { return valueType; } }

        public static implicit operator T(BaseValue<T> reference)
        {
            return reference.Value;
        }

        protected virtual void OnEnable()
        {
            //Prevents the asset from being unloaded when there are no scene references to it
            hideFlags = HideFlags.DontUnloadUnusedAsset;

#if UNITY_EDITOR
            runtimeValue = value;
#endif
        }

#if UNITY_EDITOR
        protected virtual void OnValidate()
        {
            if (!Application.isPlaying)
            {
                runtimeValue = value;
            }
        }
#endif
    }
}