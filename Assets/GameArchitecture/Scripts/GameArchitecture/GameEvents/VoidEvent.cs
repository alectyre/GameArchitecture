using UnityEngine;

namespace GameArchitecture.GameEvents
{
    [System.Serializable] public struct Void { }

    [CreateAssetMenu(fileName = "New VoidEvent", menuName = "GameArchitecture/Events/VoidEvent")]
    public class VoidEvent : BaseGameEvent<Void>
    {
        public void Raise() => Raise(new Void());
    }
}