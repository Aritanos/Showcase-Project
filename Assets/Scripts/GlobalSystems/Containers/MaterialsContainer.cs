using System.Collections.Generic;
using UnityEngine;

namespace Colortribes
{
    [CreateAssetMenu(fileName = "Materials Container", menuName = "Containers/Materials")]
    public class MaterialsContainer : ScriptableObject, IContainer<ColorType, Material>
    {
        [SerializeField] private Material _enemyMaterial;
        [SerializeField] private Material _playerMaterial;
        [SerializeField] private Material _neutralMaterial;

        public Dictionary<ColorType, Material> Get { get; set; } = new Dictionary<ColorType, Material>();

        public void Init()
        {
            Get.Add(ColorType.Player, _playerMaterial);
            Get.Add(ColorType.Enemy1, _enemyMaterial);
            Get.Add(ColorType.Neutral, _neutralMaterial);
        }
    }
}
