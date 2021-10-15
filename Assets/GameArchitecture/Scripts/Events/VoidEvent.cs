using UnityEngine;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.Events
{
    [CreateAssetMenu(fileName = "NewVoidEvent", menuName = "GameArchitecture/Events/VoidEvent")]
    public class VoidEvent : BaseEvent<Void, VoidUnityEvent>
    {
        public void Raise() => Raise(new Void());
    }
}