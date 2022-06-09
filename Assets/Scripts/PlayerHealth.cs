using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerHealth : IDamage
    {       
        private float _maxHealth { get; }
        private float _currentHealth {get; set;}  

        private GameObject _player;
        private readonly ProviderPlayer _providerPlayer;



        //private void OnCollisionEnter(Collision2D other) // Как использовать без монобеха? 
        //{
        //    if (__currentHealth <= 0)
        //    {
        //        Destroy(gameObject);
        //    }
        //    else
        //    {
        //        __currentHealth--;
        //    }
        //}

        public PlayerHealth(float CurrentHealth, GameObject player)
        {
            _currentHealth = CurrentHealth;
            _player = player; 
            
        }

        public void GetDamage()
        {
            _currentHealth--;          
        }

        public void AddHealth()
        {
            _currentHealth++; 
        }

        public Controller(ProviderPlayer providerPlayer) 
        {
            _providerPlayer = providerPlayer;
            _providerPlayer.OnCollisionEnterChange += ProviderOnOnCollisionEnterChange;
        }

        private void ProviderOnOnCollisionEnterChange(string obj)
        {
            Debug.Log(obj); 
        }

        ~Controller() 
        {
            _providerPlayer.OnCollisionEnterChange -= ProviderOnOnCollisionEnterChange;
        }


    }

} 

