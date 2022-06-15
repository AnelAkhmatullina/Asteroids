namespace Asteroids
{
    public interface IEnemyFactory
    {
        EnemyManager Create(float hp);
    } 
}

