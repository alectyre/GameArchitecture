using System;
using UnityEngine.Events;

namespace GameArchitecture.UnityEvents
{
    [Serializable] public struct Void { }

    [Serializable] public class VoidUnityEvent : UnityEvent<Void> { }
}