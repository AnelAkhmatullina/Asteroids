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
        }

        public void AddHealth() 
        {
            _hp++;  
        }
         
    }

} 

