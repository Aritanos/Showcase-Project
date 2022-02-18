using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
