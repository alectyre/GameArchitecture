using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameArchitecture.Events
{
    //TODO Aren't we breaking the 'inheritence is not for code reuse' priciple with these base classes?
    public abstract class BaseEvent<T> : ScriptableObject
    {
        [SerializeField, TextArea(4, 20)] private string description = "";

        private readonly List<Action<T>> listeners = new List<Action<T>>();



        public string Description { get { return description; } }

        public void Raise(T item)
        {
            for (int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i]?.Invoke(item);
            }
        }

        public void RegisterListener(Action<T> action)
        {
            if (!listeners.Contains(action))
            {
                listeners.Add(action);
            }
        }

        public void UnregisterListener(Action<T> action)
        {
            if (listeners.Contains(action))
            {
                listeners.Remove(action);
            }
        }
    }
}