using Colortribes.ShootSystem;
using UnityEngine;

namespace Colortribes
{
    [CreateAssetMenu(fileName = "Prefabs Container", menuName = "Containers/Prefabs")]
    public class PrefabsContainer : ScriptableObject
    {
        public ProjectilePrefabsContainer Projectiles;

        public void Init()
        {
            Projectiles.Init();
        }
    }
}
