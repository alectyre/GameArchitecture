using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GameArchitecture.Collections
{
    public abstract class BaseSet<T> : ScriptableObject
    {
        [SerializeField] protected SetType setType = SetType.Variable;
        [SerializeField] private List<T> items = null;
        [SerializeField, Tooltip("Unique items only enforced during runtime using Add function.")] private bool allowDuplicates = true;

        [SerializeField] private List<T> runtimeItems = null;

        private List<T> Items 
        {
#if UNITY_EDITOR
            get { return runtimeItems; }
#else
            get { return items; }
#endif
        }

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
            }
        }

        public void Remove(T item)
        {
            if (!Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        public bool Contains(T item)
        {
            return Items.Contains(item);
        }

        public void Clear()
        {
            Items.Clear();
        }

        public int Count()
        {
            return Items.Count;
        }


        private void OnEnable()
        {
            CopyItemsToRuntimeItems();

            hideFlags = HideFlags.DontUnloadUnusedAsset; //Prevents the asset from being unloaded when there are no scene references to it
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


        #region Debug

        public string ItemsToString()
        {
            return ListToString(items);
        }

        public string RuntimeItemsToString()
        {
            return ListToString(runtimeItems);
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