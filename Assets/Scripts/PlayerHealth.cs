using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerHealth: IDamage
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _hp;

        private GameObject _player; 
        
        

        //private void OnCollisionEnter(Collision2D other) // Как использовать без монобеха? 
        //{
        //    if (_hp <= 0)
        //    {
        //        Destroy(gameObject);
        //    }
        //    else
        //    {
        //        _hp--;
        //    }
        //}

        public PlayerHealth(float hp, GameObject player)
        {
            _hp = hp;
            _player = player; 
            
        }

        public void GetDamage()
        {
            _hp--;          
        }

        public void AddHealth()
        {
            _hp++; 
        }
        
    }
  
} 

