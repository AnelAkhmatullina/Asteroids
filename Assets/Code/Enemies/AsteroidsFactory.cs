using UnityEngine;

namespace Asteroids
{
    internal sealed class AsteroidsFactory : IEnemyFactory
    {
        public EnemyManager Create(float hp)
        {
            var enemyFactory = Object.Instantiate(Resources.Load<Asteroid>("Enemies/AsteroidsFactory")); 
            enemyFactory.DependencyInjectHealth(hp); 
            return enemyFactory;     
        }
    }
}   


