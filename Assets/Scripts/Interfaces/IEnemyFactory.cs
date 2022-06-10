namespace Asteroids
{
    public interface IEnemyFactory
    {
        EnemyManager Create(Health hp);
    } 
}

