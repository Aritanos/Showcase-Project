using UnityEngine;
using Colortribes.FightSystem;

namespace Colortribes
{
    public class Level : MonoBehaviour
    {
        [SerializeField] private DummyHandler _dummyHandler;
        [SerializeField] private DummyRepository _dummyRepository;
        [SerializeField] private Transform _playerPosition;
        [SerializeField] private Transform _enemyPosition;
        [SerializeField] private Transform _fightingPosition;

        public DummyRepository DummyRepository
        {
            get
            {
                return _dummyRepository;
            }
        }

        public Transform FightingPosition
        {
            get
            {
                return _fightingPosition;
            }
        }
        public void Init(Transform player, Transform enemy)
        {
            //_dummyHandler.Init();
            player.SetPositionAndRotation(_playerPosition.position, _playerPosition.rotation);
            enemy.SetPositionAndRotation(_enemyPosition.position, _enemyPosition.rotation);
        }

        public void StartFighting(float time)
        {
            _dummyHandler.StartFight();
        }
    }
}
