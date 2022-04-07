namespace Colortribes.ShootSystem
{
    public interface IShooter
    {
        public ColorType ColorType { get; }
        public void StartShooting();
        public void StopShooting();
    }
}
