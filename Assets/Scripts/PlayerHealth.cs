using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerHealth : IDamage
    {
        public Health hp;
        

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

        public PlayerHealth(int CurrentHealth, GameObject player)
        {
            _currentHealth = CurrentHealth;
            _player = player; 
            
        }

        public void GetDamage()
        {
            hp--;          
        }

        public void AddHealth() 
        {
            hp++; 
        }

        public GameController(ProviderPlayer providerPlayer) 
        {
            _providerPlayer = providerPlayer;
            _providerPlayer.OnCollisionEnterChange += ProviderOnOnCollisionEnterChange;
        }

        private void ProviderOnOnCollisionEnterChange(string obj)
        {
            Debug.Log(obj); 
        }

        Controller() 
        {
            _providerPlayer.OnCollisionEnterChange -= ProviderOnOnCollisionEnterChange;
        }


    }

} 

