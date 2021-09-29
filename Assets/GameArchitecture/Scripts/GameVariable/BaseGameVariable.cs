using UnityEngine;

namespace GameArchitecture.GameVariables
{
    public abstract class BaseGameVariable<T> : ScriptableObject
    {
        [SerializeField] private T value;
        [SerializeField, TextArea(4, 20)] private string description = "";
        [SerializeField] private bool runtimeEditable = false;

        private T runtimeValue; //TODO custom inspector to display runtimeValue



        public T Value
        {
            get { return runtimeEditable ? value : runtimeValue; }
            set { if (runtimeEditable) this.value = value; runtimeValue = value; }
        }

        public string Description { get { return description; } }

        public static implicit operator T(BaseGameVariable<T> reference)
        {
            return reference.Value;
        }

        private void OnEnable()
        {
            runtimeValue = value;
        }
    }
}