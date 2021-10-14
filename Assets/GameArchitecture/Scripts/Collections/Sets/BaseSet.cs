using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Collections
{
    public abstract class BaseSet<T> : ScriptableObject, IEnumerable<T>
    {
        [SerializeField] protected SetType setType = SetType.Variable;
        [SerializeField, Tooltip("Unique items only enforced during runtime using Add function.")] private bool allowDuplicates = false;
        [SerializeField] private List<T> items = null;
        [SerializeField] private List<T> runtimeItems = null;
        [SerializeField, TextArea(4, 20)] private string description = "";
        [Space, SerializeField] private UnityEvent onSetChanged;

        public UnityEvent OnSetChanged { get { return onSetChanged; } set { onSetChanged = value; } }

        public string Description { get { return description; } }

        public SetType SetType { get { return setType; } }



        #region Public Set functions

        public bool AllowDuplicates
        {
            get { return allowDuplicates; }
            set
            {
                allowDuplicates = value;
                if(!allowDuplicates)
                {
                    runtimeItems = runtimeItems.Distinct().ToList();
                }
            }
        }

        public void Add(T item)
        {
            if (allowDuplicates || !Items.Contains(item))
            {
                Items.Add(item);
                onSetChanged?.Invoke();
            }
        }

        public void Remove(T item)
        {
            if (!Items.Contains(item))
            {
                Items.Remove(item);
                onSetChanged?.Invoke();
            }
        }

        public bool Contains(T item)
        {
            return Items.Contains(item);
        }

        public void Clear()
        {
            if (Items.Count > 0)
            {
                Items.Clear();
                onSetChanged?.Invoke();
            }
        }

        public int Count()
        {
            return Items.Count;
        }

        public List<T> ToList()
        {
            return new List<T>(Items);
        }

        #endregion



        #region IEnumerable funcions

        public IEnumerator<T> GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.GetEnumerator();
        }

        #endregion



        #region Private functions

        private List<T> Items
        {
#if UNITY_EDITOR
            get { return runtimeItems; }
#else
            get { return items; }
#endif
        }

        private void OnEnable()
        {
            hideFlags = HideFlags.DontUnloadUnusedAsset; //Prevents the asset from being unloaded when there are no scene references to it

#if UNITY_EDITOR
            if (Application.isPlaying)
            {
                CopyItemsToRuntimeItems();
            }
#endif
        }

        private void CopyItemsToRuntimeItems()
        {
            if (allowDuplicates)
            {
                runtimeItems = items.ToList();
            }
            else
            {
                runtimeItems = items.Distinct().ToList();
            }
        }

        #endregion



        #region Debug

        public string ItemsToString(bool runtimeItems = false)
        {
            if (runtimeItems)
            {
                return ListToString(this.runtimeItems);
            }
            else
            {
                return ListToString(items);
            }
        }

        private string ListToString(List<T> items)
        {
            string output = "";

            foreach (T item in items)
            {
                if (string.IsNullOrEmpty(output))
                {
                    output += item.ToString();
                }
                else
                {
                    output += ", " + item.ToString();
                }
            }

            return output;
        }
        
        #endregion
    }
}