using System;
using System.Collections.Generic;
using UnityEngine;

namespace GameArchitecture.GameEvents
{
    public abstract class BaseGameEvent<T> : ScriptableObject
    {
        [SerializeField, TextArea(4, 20)] private string description;

        private readonly List<Action<T>> listeners = new List<Action<T>>();



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