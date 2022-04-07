using System.Collections;
using UnityEngine;

namespace Colortribes.ShootSystem
{
    public class Shooter : MonoBehaviour, IShooter
    {
        public ColorType ColorType { get { return _colorType; } private set { } }

        [SerializeField] private Weapon _weapon;
        [SerializeField] private float _shootingPeriod;
        [SerializeField] private ColorType _colorType;

        private Coroutine _shootingCoroutine;

        public void StartShooting()
        {
            _shootingCoroutine = StartCoroutine(StartShootingCorotine(_shootingPeriod));
        }

        public void StopShooting()
        {
            if (_shootingCoroutine != null)
            {
                StopCoroutine(_shootingCoroutine);
            }
        }

        private IEnumerator StartShootingCorotine(float period)
        {
            yield return new WaitForSeconds(period);
            _weapon.Shoot(_colorType);
            _shootingCoroutine = StartCoroutine(StartShootingCorotine(_shootingPeriod));
        }
    }
}
