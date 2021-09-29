using UnityEngine;

namespace GameArchitecture.GameVariables
{
    public abstract class BaseGameVariable<T> : ScriptableObject
    {
        [SerializeField] private T value;
        [SerializeField, TextArea(4, 20)] private string description;

        public T Value { get { return value; } set { this.value = value; } }

        public static implicit operator T(BaseGameVariable<T> reference)
        {
            return reference.Value;
        }
    }
}