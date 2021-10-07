using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GameArchitecture.Collections
{
    public abstract class BaseSet<T> : ScriptableObject
    {
        [SerializeField] private List<T> items = new List<T>();
        [SerializeField, Tooltip("Unique items only enforced during runtime using Add function.")] private bool allowDuplicates = true;
        [SerializeField] private bool runtimeEditable = false;

        private List<T> runtimeItems = new List<T>();

        public bool RuntimeEditable { get { return runtimeEditable; } set { runtimeEditable = value; } }
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
            if(!runtimeEditable)
            {
                if (allowDuplicates || !runtimeItems.Contains(item))
                {
                    runtimeItems.Add(item);
                }
            }
            else 
            {
                if (allowDuplicates || !items.Contains(item))
                {
                    items.Add(item);
                }
            }
        }

        public void Remove(T item)
        {
            if (!runtimeEditable)
            {
                if (!runtimeItems.Contains(item))
                {
                    runtimeItems.Remove(item);
                }
            }
            else
            {
                if (!items.Contains(item))
                {
                    items.Remove(item);
                }
            }
        }

        public bool Contains(T item)
        {
            return !runtimeEditable ? runtimeItems.Contains(item) : items.Contains(item);
        }

        public void Clear()
        {
            if (!runtimeEditable)
            {
                runtimeItems.Clear();
            }
            else
            {
                items.Clear();
            }
        }

        public int Count()
        {
            if (!runtimeEditable)
            {
                return runtimeItems.Count;
            }
            else
            {
                return items.Count;
            }
        }



        private void OnEnable()
        {
            CopyItemsToRuntimeItems();
            hideFlags = HideFlags.DontUnloadUnusedAsset; //Prevents the asset from being unloaded when there are no scene references to it
        }

        private void OnValidate()
        {
            if(Application.isPlaying && runtimeEditable)
            {
                CopyItemsToRuntimeItems();
            }
        }

        private void CopyItemsToRuntimeItems()
        {
            runtimeItems = items.ToList();

            if (!allowDuplicates)
            {
                runtimeItems = runtimeItems.Distinct().ToList();
            }
        }



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
    }
}