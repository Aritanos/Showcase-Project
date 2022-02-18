using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShooter
{
    public ColorType ColorType { get; }
    public void StartShooting();
    public void StopShooting();
}
