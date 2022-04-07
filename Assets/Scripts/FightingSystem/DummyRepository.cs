using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Colortribes.FightSystem
{
    public class DummyRepository : MonoBehaviour
    {
        [SerializeField] private List<Dummy> _dummies = new List<Dummy>();

        private int _enemyDummiesCount = 0;
        private int _playerDummiesCount = 0;

        public void StartFight()
        {
            CountDummies();
            foreach (Dummy dummy in _dummies)
            {
                dummy.StartFight();
            }
        }

        public void RemoveDummy(Dummy dummy)
        {
            if (dummy.ColorType == ColorType.Enemy1)
                _enemyDummiesCount--;
            else if (dummy.ColorType == ColorType.Player)
                _playerDummiesCount--;
            dummy.DestroyDummy -= RemoveDummy;
            CheckDummiesCount();
        }

        public IColorable GetNearestColorable(ColorType getterType, Vector3 position)
        {
            float distance = float.PositiveInfinity;
            Dummy nearestColorableObject = null;
            foreach (Dummy dummy in _dummies)
            {
                var newDistance = Vector3.Distance(dummy.transform.position, position);
                if (newDistance < distance && dummy.ColorType != getterType)
                {
                    distance = newDistance;
                    nearestColorableObject = dummy;
                }
            }
            return nearestColorableObject;
        }

        private void Start()
        {
            for (int i = 0; i < _dummies.Count; i++)
            {
                _dummies[i].DestroyDummy += RemoveDummy;
            }
        }

        private void CheckDummiesCount()
        {
            if (_enemyDummiesCount * _playerDummiesCount == 0)
            {
                foreach (Dummy dummy in _dummies)
                {
                    dummy.SetWinCondition();
                }
            }
        }

        private void CountDummies()
        {
            foreach (Dummy dummy in _dummies)
            {
                if (dummy.ColorType == ColorType.Enemy1)
                    _enemyDummiesCount++;
                else if (dummy.ColorType == ColorType.Player)
                    _playerDummiesCount++;
            }
        }
    }
}
