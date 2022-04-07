using UnityEngine;

namespace Colortribes.ShootSystem
{
    public class WeaponRotator : MonoBehaviour
    {
        private Vector3 _rotation;

        private void Awake()
        {
            _rotation = transform.rotation.eulerAngles;
        }

        public bool SetTargetPosition(Vector3 targetWorldPosition, float rotationDelta)
        {
            var rotateVector = Vector3.RotateTowards(Vector3.forward, targetWorldPosition - transform.position, rotationDelta, 0);
            transform.rotation = Quaternion.LookRotation(rotateVector);
            return false;
        }

        public Vector3 RotateWeapon(Vector3 rotation)
        {
            _rotation = rotation;
            transform.Rotate(Vector3.right * rotation.y, Space.World);
            transform.Rotate(Vector3.up * rotation.x, Space.Self);
            return _rotation;
        }
    }
}
