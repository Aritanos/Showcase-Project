using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Prefabs Container", menuName = "Containers/Prefabs")]
public class PrefabsContainer : ScriptableObject
{
    public ProjectilePrefabsContainer Projectiles;

    public void Init()
    {
        Projectiles.Init();
    }
}
