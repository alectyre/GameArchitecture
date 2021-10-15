using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public struct Void { }

    [System.Serializable] public class VoidUnityEvent : UnityEvent<Void> { }

    [CreateAssetMenu(fileName = "NewVoidEvent", menuName = "GameArchitecture/Events/VoidEvent")]
    public class VoidEvent : BaseEvent<Void, VoidUnityEvent>
    {
        public void Raise() => Raise(new Void());
    }
}