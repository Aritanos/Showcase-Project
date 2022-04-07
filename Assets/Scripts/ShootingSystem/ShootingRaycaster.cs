using UnityEngine;

namespace Colortribes.ShootSystem
{
    public class ShootingRaycaster : MonoBehaviour
    {
        public RaycastHit GetRaycastHit(Ray ray)
        {
            Physics.Raycast(ray, out RaycastHit hit);
            return hit;
        }
    }
}
