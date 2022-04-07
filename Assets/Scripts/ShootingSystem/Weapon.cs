using UnityEngine;

namespace Colortribes.ShootSystem
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private float _minShootinPeriod;
        [SerializeField] private float _weaponProjectileSpeed;
        [SerializeField] private Transform _startingProjectilePosition;

        public void Shoot(ColorType colorType)
        {
            Instantiate(Containers.PrefabsContainer.Projectiles.Get[colorType], _startingProjectilePosition.position, Quaternion.identity, GameHandler.DefaultParent).
                Init(new ProjectileProperties(_weaponProjectileSpeed, transform.TransformDirection(Vector3.forward), colorType));
        }
    }
}
