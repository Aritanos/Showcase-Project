using UnityEngine;

namespace Colortribes.ShootSystem
{
    public struct ProjectileProperties
    {
        public readonly ColorType ColorType;
        public readonly float Speed;
        public readonly Vector3 Direction;

        public ProjectileProperties(float speed, Vector3 direction, ColorType colorType)
        {
            Speed = speed;
            ColorType = colorType;
            Direction = direction;
        }
    }
}
