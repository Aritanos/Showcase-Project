using System.Collections.Generic;
using UnityEngine;

namespace Colortribes
{
    public class LevelHandler : MonoBehaviour
    {
        public static Level CurrentLevel { get; private set; }

        [SerializeField] private List<Level> _levels = new List<Level>();

        [SerializeField] private Transform _playerTransform;
        [SerializeField] private Transform _enemyTransform;

        public void LoadLevel(int currentLevelIndex)
        {
            if (CurrentLevel != null)
                Destroy(CurrentLevel.gameObject);
            CurrentLevel = Instantiate(_levels[currentLevelIndex], transform);
            CurrentLevel.Init(_playerTransform, _enemyTransform);
        }
    }
}
