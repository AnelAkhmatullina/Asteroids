namespace Asteroids
{
    public interface IDamage
    {
        float Hp { get; } 

        void GetDamage();

        void AddHealth();

    }
}