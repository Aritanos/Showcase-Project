using UnityEngine;

namespace Colortribes.FightSystem
{
    public class DummyHandler : MonoBehaviour
    {
        [SerializeField] private DummyRepository _dummyRepository;

        public void StartFight()
        {
            _dummyRepository.StartFight();
        }
    }
}
