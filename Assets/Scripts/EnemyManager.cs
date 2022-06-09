using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids
{
    public class EnemyManager : MonoBehaviour, IDamage
    {
        public int HP = 0; 
        public static Asteroid CreateAsteroidEnemy(Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>("Enemy/Asteroid"));
            enemy.Health = hp;
            return enemy;
        }

        public void GetDamage()
        {
            HP--;
            if (HP <= 0) 
            {
                Destroy(this.gameObject);
            }
        }

        public void AddHealth()
        {
            HP++;
        } 
    }
 
}
