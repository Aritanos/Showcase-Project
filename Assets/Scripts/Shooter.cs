using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour, IShooter
{
    [SerializeField] private Weapon _weapon;

    [SerializeField] private float _shootingPeriod;

    private Coroutine _shootingCoroutine;

    [SerializeField] private ColorType _colorType;

    public ColorType ColorType { get { return _colorType; } private set { } }

    public void StartShooting()
    {
        _shootingCoroutine = StartCoroutine(StartShootingCorotine(_shootingPeriod));
    }

    public void StopShooting()
    {
        StopCoroutine(_shootingCoroutine);
    }

    private IEnumerator StartShootingCorotine(float period)
    {
        yield return new WaitForSeconds(period);
        _weapon.Shoot(_colorType);
        _shootingCoroutine = StartCoroutine(StartShootingCorotine(_shootingPeriod));
    }
}
