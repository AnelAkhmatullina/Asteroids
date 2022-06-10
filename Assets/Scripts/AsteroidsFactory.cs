using UnityEngine;

namespace Asteroids
{
    internal sealed class AsteroidsFactory : IEnemyFactory
    {
        public EnemyManager Create(Health hp)
        {
            var enemy =
            Object.Instantiate(Resources.Load<Asteroid>("Sprites/AsteroidFromFactory")); 
            enemy.DependencyInjectHealth(hp); 
            return enemy; 
        }
    }
}


