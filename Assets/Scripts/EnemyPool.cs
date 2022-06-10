using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Asteroids
{
    internal sealed class EnemyPool
    {
        private readonly Dictionary<string, HashSet<EnemyManager>> _enemyPool;
        private readonly int _capacityPool;
        private Transform _rootPool;
        public EnemyPool(int capacityPool)
        {
            _enemyPool = new Dictionary<string, HashSet<EnemyManager>>();
            _capacityPool = capacityPool;
            if (!_rootPool)
            {
                _rootPool = new
                GameObject(AmmunitionPool.POOL_AMMUNITION).transform;
            }
        }

        public EnemyManager GetEnemy(string type)
        {
            EnemyManager result;
            switch (type)
            {
                case "Tie":
                    result = GetAsteroid(GetListEnemies(type));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type,
                    "Не предусмотрен в программе");
            }
            return result;
        }

        private HashSet<EnemyManager> GetListEnemies(string type)
        {
            return _enemyPool.ContainsKey(type) ? _enemyPool[type] :
            _enemyPool[type] = new HashSet<EnemyManager>();
        }

        private EnemyManager GetAsteroid(HashSet<EnemyManager> enemies)
        {
            var enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            if (enemy == null)
            {
                var laser = Resources.Load<Asteroid>("Sprites/tie"); 
                for (var i = 0; i < _capacityPool; i++)
                {
                    var instantiate = Object.Instantiate(laser);
                    ReturnToPool(instantiate.transform);
                    enemies.Add(instantiate);
                }
                GetAsteroid(enemies); 
            }
            enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            return enemy; 
        }

        private void ReturnToPool(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.gameObject.SetActive(false);
            transform.SetParent(_rootPool); 
        }
        public void RemovePool()
        {
            Object.Destroy(_rootPool.gameObject);
        }

         


    }

} 