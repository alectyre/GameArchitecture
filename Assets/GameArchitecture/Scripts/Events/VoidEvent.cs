using UnityEngine;

namespace GameArchitecture.Events
{
    [System.Serializable] public struct Void { }

    [CreateAssetMenu(fileName = "NewVoidEvent", menuName = "GameArchitecture/Events/VoidEvent")]
    public class VoidEvent : BaseEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}