using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Projectile Prefabs Container", menuName = "Containers/Prefabs/ProjectilePrefabs")]
public class ProjectilePrefabsContainer : ScriptableObject, IContainer<ColorType, Projectile>
{
    [SerializeField] private Projectile _playerProjectile;
    [SerializeField] private Projectile _enemyProjectile;

    public Dictionary<ColorType, Projectile> Get { get; set; } = new Dictionary<ColorType, Projectile>();

    public void Init()
    {

        Get.Add(ColorType.Player, _playerProjectile);
        Get.Add(ColorType.Enemy1, _enemyProjectile);
    }
}
