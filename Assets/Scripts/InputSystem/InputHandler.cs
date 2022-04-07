using UnityEngine;
using Colortribes.ShootSystem;

//receiving Input Events
namespace Colortribes.InputSystem
{
    public class InputHandler : MonoBehaviour
    {
        [SerializeField] private WeaponRotator _rotator;
        [SerializeField] private Shooter _shooter;
        [SerializeField] private InputParameters _inputParameters;
        [SerializeField] private float _deltaCoefficient = 1;

        private Vector3 _startPosition = Vector3.positiveInfinity;
        private IInputReceiver _currentInputReceiver;

        private void Awake()
        {
            _currentInputReceiver = _inputParameters.GetCurrentInputReceiver();
            _currentInputReceiver.PointerDown += OnPointerDown;
            _currentInputReceiver.PointerHold += OnPointerHold;
            _currentInputReceiver.PointerUp += OnPointerUp;
        }

        private void OnPointerDown(Vector3 position)
        {
            _startPosition = position;
            _shooter.StartShooting();
        }

        private void OnPointerHold(Vector3 position)
        {
            var delta = position - _startPosition;
            _startPosition = position;

            if (delta != Vector3.zero)
            {
                _rotator.RotateWeapon(delta * _deltaCoefficient);
            }
        }

        private void OnPointerUp(Vector3 position)
        {
            _shooter.StopShooting();
        }
    }
}

