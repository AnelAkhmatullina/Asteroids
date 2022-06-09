namespace Asteroids
{
    public interface IDamage
    {
        int HP { get; set; } 

        void GetDamage();

        void AddHealth();
    }
}