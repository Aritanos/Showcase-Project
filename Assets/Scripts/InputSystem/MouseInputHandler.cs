using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Colortribes.InputSystem
{
    public class MouseInputHandler : MonoBehaviour, IInputReceiver
    {
        public event Action<Vector3> PointerDown;
        public event Action<Vector3> PointerHold;
        public event Action<Vector3> PointerUp;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                PointerDown?.Invoke(Input.mousePosition);
            }

            if (Input.GetMouseButton(0))
            {
                PointerHold?.Invoke(Input.mousePosition);
            }

            if (Input.GetMouseButtonUp(0))
            {
                PointerUp?.Invoke(Input.mousePosition);
            }
        }
    }
}
