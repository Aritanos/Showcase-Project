using UnityEngine;
using UnityEngine.AI;

namespace Colortribes.FightSystem
{
    public class DummyPathFInder : MonoBehaviour
    {
        [SerializeField] private NavMeshAgent _navAgent;

        private Transform _targetTransform;

        public void SetTarget(Transform target)
        {
            this.enabled = true;
            _targetTransform = target;
            _navAgent.SetDestination(target.position);
        }

        private void Update()
        {
            if (_targetTransform != null)
            {
                transform.LookAt(_targetTransform);
            }
        }

        public void DisableNavigation()
        {
            _navAgent.isStopped = true;
        }
    }
}
