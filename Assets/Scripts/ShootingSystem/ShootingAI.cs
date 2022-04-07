using UnityEngine;
using Colortribes.FightSystem;

//behavior противника
namespace Colortribes.ShootSystem
{
    public class ShootingAI : MonoBehaviour
    {
        [SerializeField] private Shooter _shooter;
        [SerializeField] private WeaponRotator _weaponRotator;

        private IColorable nearestColorableObject = null;

        public void AwakeShooterAI()
        {
            FindNewColorable();
            _shooter.StartShooting();
            this.enabled = true;
        }

        public void DisableShooterAI()
        {
            _shooter.StopShooting();
            this.enabled = false;
        }

        private void Update()
        {
            FindNewColorable();
        }

        private void FindNewColorable()
        {
            if (GameHandler.CurrentGamePhase == GamePhase.Shooting)
            {
                if (nearestColorableObject == null || nearestColorableObject.ColorType == _shooter.ColorType)
                {
                    nearestColorableObject = LevelHandler.CurrentLevel.DummyRepository.GetNearestColorable(_shooter.ColorType, transform.position);
                    if (nearestColorableObject == null)
                    {
                        _shooter.StopShooting();
                        return;
                    }
                    else
                    {
                        _weaponRotator.SetTargetPosition(nearestColorableObject.Transform.position + Vector3.up * 0.5f, 100);
                    }
                }
            }
            else
            {
                _shooter.StopShooting();
            }
        }
    }
}
