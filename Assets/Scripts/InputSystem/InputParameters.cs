using UnityEngine;

namespace Colortribes.InputSystem
{
    public class InputParameters : MonoBehaviour
    {
        [SerializeField] private MouseInputHandler mouseInput;

        public IInputReceiver GetCurrentInputReceiver()
        {
#if UNITY_EDITOR
            return mouseInput;
#else
        return null;
#endif
        }
    }
}
