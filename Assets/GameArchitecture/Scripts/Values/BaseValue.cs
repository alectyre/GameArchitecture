using UnityEngine;
using System.Collections.Generic;
using System;
using System.IO;

namespace GameArchitecture.Values
{
    public abstract class BaseValue<T> : ScriptableObject
    {
        [SerializeField] protected T value;
        [SerializeField] protected ValueType valueType = ValueType.Variable;
        [SerializeField, TextArea(4, 20)] private string description = "";

//#if UNITY_EDITOR
        /// <summary> value is copied to runtimeValue when running in the editor to avoid overwriting seralized value. </summary>
        [SerializeField]  private T runtimeValue;
//#endif

        // Currently not supporting onValueChanged events in EditMode carrying over to PlayMode. If we want to change that, look at Button source.
        [SerializeField] private List<Action<T>> onValueChangedListeners = new List<Action<T>>();

        public T Value
        {
#if UNITY_EDITOR
            get { return runtimeValue; }
            set
            {
                if (valueType == ValueType.Constant)
                {
                    Debug.LogError("Trying to modify " + GetType().Name + " " + name + " but it is set to Constant.");
                    return;
                }
                
                bool valueChanged = !runtimeValue.Equals(value);
                
                runtimeValue = value;
                
                if (valueChanged)
                {
                    RaiseOnValueChanged(Value);
                }
            }
#else
            get { return value; }
            set
            {
                if (valueType == ValueType.Constant)
                {
                    Debug.LogError("Trying to modify " + GetType().Name + " " + name + " but it is set to Constant.");
                    return;
                }
                
                bool valueChanged = !this.value.Equals(value);
                
                this.value = value;
                
                if (valueChanged)
                {
                    RaiseOnValueChanged(Value);
                }
            }
#endif
        }

        public string Description { get { return description; } }

        public ValueType DataType { get { return valueType; } }

        public static implicit operator T(BaseValue<T> reference)
        {
            return reference.Value;
        }

        public void AddListenerOnValueChanged(Action<T> action)
        {
            if (!onValueChangedListeners.Contains(action))
            {
                onValueChangedListeners.Add(action);
            }
        }

        public void RemoveListenerOnValueChanged(Action<T> action)
        {
            if (!onValueChangedListeners.Contains(action))
            {
                onValueChangedListeners.Remove(action);
            }
        }

        private void RaiseOnValueChanged(T item)
        {
            for (int i = onValueChangedListeners.Count - 1; i >= 0; i--)
            {
                onValueChangedListeners[i]?.Invoke(item);
            }
        }

        protected virtual void OnEnable()
        {
            //Prevents the asset from being unloaded when there are no scene references to it
            hideFlags = HideFlags.DontUnloadUnusedAsset;

#if UNITY_EDITOR
            runtimeValue = value;
#endif
        }

        public string ToJson()
        {
            JsonData jsonData = new JsonData()
            {
                value = this.value,
                valueType = this.valueType
            };
            return JsonUtility.ToJson(jsonData);
        }

        public void FromJson(string json)
        {
            JsonUtility.FromJson<JsonData>(json).Apply(this);
        }

        private struct JsonData
        {
            public T value;
            public ValueType valueType;

            public void Apply(BaseValue<T> baseValue)
            {
                baseValue.value = value;
                baseValue.valueType = valueType;
            }
        }

        /*
         * Some issues:
         * Ensuring unnique file names for each Value asset.
         * Having a file for each Value seems kind of messy?
         */
        private string SaveDataPath { get { return Application.persistentDataPath + Path.DirectorySeparatorChar + "savedata.json"; } }

        public void Save()
        {
            string jsonString = JsonUtility.ToJson(this);
            //string jsonString = ToJson();

            File.WriteAllText(SaveDataPath, jsonString);
        }

        public void Load()
        {
            if (!File.Exists(SaveDataPath))
            {
                return;
            }

            string jsonString = File.ReadAllText(SaveDataPath);

            JsonUtility.FromJsonOverwrite(jsonString, this);
            //FromJson(jsonString);
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