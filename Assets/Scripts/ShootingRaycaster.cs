using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRaycaster : MonoBehaviour
{
    public RaycastHit GetRaycastHit(Ray ray)
    {
        Physics.Raycast(ray, out RaycastHit hit);
        return hit;
    }
}
