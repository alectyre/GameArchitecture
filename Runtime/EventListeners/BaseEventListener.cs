using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.Events;

namespace GameArchitecture.EventListeners
{
    public abstract class BaseEventListener<T, GE, UE> : MonoBehaviour where GE : BaseEvent<T, UE> where UE : UnityEvent<T>
    {
        [SerializeField] private GE gameEvent= null;
        [SerializeField, Space] private UE onEventTriggered = null;

        private void HandleEvent(T item)
        {
            onEventTriggered?.Invoke(item);
        }

        protected virtual void OnEnable()
        {
            if (gameEvent != null)
            {
                gameEvent.OnEventRaise.AddListener(HandleEvent);
            }
        }

        protected virtual void OnDisable()
        {
            if (gameEvent != null)
            {
                gameEvent.OnEventRaise.RemoveListener(HandleEvent);
            }
        }
    }
}