using UnityEngine;


namespace Asteroids
{
    internal abstract class EnemyManager : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public Transform _rotPool; 
        public Health _health;

        public Health Health
        {
            get
            {
                if(_health.CurrentHealth <= 0.0f)
                {
                    ReturnToPool();
                }
                return _health; 
            }
            protected set => _health = value; 
        }

        public Transform RotPool
        {
            get
            {
                if(_rotPool == null)
                {
                    var find = GameObject.Find(AmmunitionPool.POOL_AMMUNITION);
                    _rotPool = find == null ? null : find.transform; 
                }
                return _rotPool; 
            } 
        } 


        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Sprites/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }

        public void DependencyInjectHealth(Health hp)
        {
            Health = hp;
        }

        public void ActiveEnemy(Vector3 position, Quaternion rotation)
        {
            transform.localPosition = position;
            transform.localRotation = rotation;
            gameObject.SetActive(true);
            transform.SetParent(null);
        }

        protected void ReturnToPool()
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            gameObject.SetActive(false);
            transform.SetParent(RotPool);

            if (!RotPool)
            {
                Destroy(gameObject); 
            }
        }
    }
 
}
