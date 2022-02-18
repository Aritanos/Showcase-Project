using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Update()
    {
        //if (nearestColorableObject?.ColorType == _shooter.ColorType)
        //{
            FindNewColorable();
        //}
    }

    private void FindNewColorable()
    {
        if (GameHandler.CurrentGamePhase == GamePhase.Fighting)
        {
            if (nearestColorableObject?.ColorType == _shooter.ColorType)
            {
                nearestColorableObject = DummyRepository.GetNearestDummy(_shooter.ColorType, transform.position);
                if (nearestColorableObject == null)
                {
                    _shooter.StopShooting();
                    return;
                }
                _weaponRotator.SetTargetPosition(nearestColorableObject.Transform.position + Vector3.up * 0.5f, 100);
            }           
        }
    }
}
