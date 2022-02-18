using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInputHandler : MonoBehaviour
{
    [SerializeField] private WeaponRotator _handler;

    [SerializeField] private float _deltaCoefficient = 0;

    private Touch _touch = new Touch();

    private Vector2 _startPosition = Vector2.zero;

    private void Update()
    {
        if (_touch.phase == TouchPhase.Began)
        {
            //set start pos
            _startPosition = _touch.position;
        }

        if (_touch.phase == TouchPhase.Moved)
        {
            //send pos change
            _handler.RotateWeapon((_touch.position - _startPosition) * _deltaCoefficient);
            //set new start pos
        }

    }
}
