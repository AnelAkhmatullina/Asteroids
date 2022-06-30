namespace Asteroids
{
    public sealed class Asteroid : EnemyManager, IDamage
    {
        //private float _hp;
        private EnemyView _enemy;
        public float Hp => _hp;


        public Asteroid(float currentHealth, EnemyView enemy) 
        {
            _hp = currentHealth;
            _enemy = enemy;
            _enemy.OnCollisionEnter += GetDamage; // подписываемся на событие

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
