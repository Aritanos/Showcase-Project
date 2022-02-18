using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotator : MonoBehaviour
{
    private Vector3 _rotation;

    private Vector3 _initialRotation;

    private void Awake()
    {
        _initialRotation = transform.rotation.eulerAngles;
        _rotation = transform.rotation.eulerAngles;
    }

    public bool SetTargetPosition(Vector3 targetWorldPosition, float rotationDelta)
    {
        var rotateVector = Vector3.RotateTowards(transform.rotation.eulerAngles, targetWorldPosition - transform.position, rotationDelta, 0);
        transform.rotation = Quaternion.LookRotation(rotateVector);
        return false;
    }

    public Vector3 RotateWeapon(Vector3 rotation)
    {
        _rotation = rotation;
        transform.Rotate(Vector3.left * rotation.y, Space.World);
        transform.Rotate(Vector3.up * rotation.x, Space.Self);
        //LimitRotation(transform.localRotation.eulerAngles);
        return _rotation;
    }

    private void LimitRotation(Vector3 rotation)
    {
        if (rotation.x > 55 && rotation.x < 180 )
            rotation.x = 55;
        if (rotation.x < 315 && rotation.x > 180)        
            rotation.x = 315;

        if (rotation.y > 30 && rotation.y < 180)
            rotation.y = 30;
        if (rotation.y < 330 && rotation.y > 180)
            rotation.y = 330;

        //rotation.z = 0;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
