using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerHealth : IDamage
    {
        private float _hp;
        private ShipView _player;       
        public float Hp => _hp; 
      

        public PlayerHealth(float currentHealth, ShipView player)
        {
            _hp = currentHealth;
            _player = player;
            _player.OnCollisionEnter += GetDamage; // подписываемся на событие
            
        }

        public void GetDamage()
        {
            _hp--;
            if (_hp < 0)
            {
                _player.gameObject.SetActive(false); 
            }

            Debug.Log($"Game Over"); 
        }

        public void AddHealth() 
        {
            _hp++;

            Debug.Log($"HP +");
        }
         
    }

} 

