using UnityEngine;

namespace Asteroids
{
    public abstract class EnemyManager : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public float _hp; 

        public static Asteroid CreateAsteroidEnemy(float hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemies/Asteroid"));
            enemy.DependencyInjectHealth(hp);
            return enemy;
        }

        public static Saucer CreateSaucerEnemy(float hp)
        {
            var enemy = Instantiate(Resources.Load<Saucer>("Enemies/Saucer")); 
            enemy.DependencyInjectHealth(hp);
            return enemy; 
        }

        public void DependencyInjectHealth(float hp)
        {
            _hp = hp; 
        }
    }
}  

