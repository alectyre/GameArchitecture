using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    public abstract class BaseEvent<T, E> : ScriptableObject where E : UnityEvent<T>
    {
        [SerializeField, LockableTextArea(4, 20)] private string description = "";
        [SerializeField, Space] private E onEventRaised; 

        public E OnEventRaise { get { return onEventRaised; } set { onEventRaised = value; } }

        public string Description { get { return description; } }

        public void Raise(T item)
        {
            onEventRaised?.Invoke(item);
        }
    }
}