using UnityEngine;

namespace Asteroids
{
    public abstract class EnemyManager : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public float _hp;
       

        public static Asteroid CreateAsteroidEnemy(float hp) // 1-й тип врага Астероид
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemies/Asteroid"));
            enemy.DependencyInjectHealth(hp);
            return enemy;
        }

        public static Saucer CreateSaucerEnemy(float hp) // 2-й тип врага Летающая тарелка
        {
            var enemy = Instantiate(Resources.Load<Saucer>("Enemies/Saucer")); 
            enemy.DependencyInjectHealth(hp);
            return enemy; 
        }

        public void DependencyInjectHealth(float hp)
        {
            _hp = hp; 
        }

        private void Start() //2-й тип врага Летающая тарелка Создание через прототип
        {
            EnemyData enemyData = new EnemyData();

            if(enemyData.Hp < 50)
            {
                EnemyData enemyDataNew = enemyData.DeepCopy();
                Debug.Log(enemyDataNew);
            }

             
            Debug.Log(enemyData);
            
        }
    }
}  

