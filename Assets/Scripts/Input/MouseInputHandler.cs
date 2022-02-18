using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseInputHandler : MonoBehaviour
{
    [SerializeField] private ShootingRaycaster _rayCaster;
    [SerializeField] private WeaponRotator _rotator;
    [SerializeField] private Shooter _shooter;

    [SerializeField] private float _deltaCoefficient = 0;

    private Vector3 _startPosition = Vector3.zero;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _startPosition = Input.mousePosition;
            _shooter.StartShooting();
        }

        if (Input.GetMouseButton(0))
        {

            var delta = Input.mousePosition - _startPosition;
            if (delta !=Vector3.zero)
            {
                _rotator.RotateWeapon(delta * _deltaCoefficient);
            }
            _startPosition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            _shooter.StopShooting();
        }
    }
}
