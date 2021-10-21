using GameArchitecture.Events;
using GameArchitecture.UnityEvents;

namespace GameArchitecture.EventListeners
{
    public class StringEventListener : BaseEventListener<string, StringEvent, StringUnityEvent> { }
}