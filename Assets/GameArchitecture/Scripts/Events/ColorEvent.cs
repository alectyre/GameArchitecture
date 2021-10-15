using UnityEngine;
using UnityEngine.Events;

namespace GameArchitecture.Events
{
    [System.Serializable] public class ColorUnityEvent : UnityEvent<Color> { }

    [CreateAssetMenu(fileName = "NewColorEvent", menuName = "GameArchitecture/Events/ColorEvent")]
    public class ColorEvent : BaseEvent<Color, ColorUnityEvent> { }
}