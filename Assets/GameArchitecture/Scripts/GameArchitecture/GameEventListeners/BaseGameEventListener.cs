using UnityEngine;
using UnityEngine.Events;
using GameArchitecture.GameEvents;

namespace GameArchitecture.GameEventListeners
{
    public abstract class BaseGameEventListener<T, GE, UE> : MonoBehaviour where GE : BaseGameEvent<T> where UE : UnityEvent<T>
    {
        [SerializeField] private GE gameEvent= null;
        [SerializeField] private UE onEventTriggered = null;



        private void HandleEvent(T item)
        {
            onEventTriggered?.Invoke(item);
        }

        protected virtual void OnEnable()
        {
            if (gameEvent != null)
            {
                gameEvent.RegisterListener(HandleEvent);
            }
        }

        protected virtual void OnDisable()
        {
            if (gameEvent != null)
            {
                gameEvent.UnregisterListener(HandleEvent);
            }
        }
    }
}