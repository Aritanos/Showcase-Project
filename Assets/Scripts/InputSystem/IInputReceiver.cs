using UnityEngine;
using System;

namespace Colortribes.InputSystem
{
    public interface IInputReceiver
    {
        public event Action<Vector3> PointerDown;
        public event Action<Vector3> PointerHold;
        public event Action<Vector3> PointerUp;
    }
}
