using GameArchitecture.Events;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.EventListeners
{
    public class BoolEventListener : BaseEventListener<bool, BoolEvent, BoolUnityEvent> { }
}