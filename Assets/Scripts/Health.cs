using UnityEngine;

namespace Asteroids
{
    internal sealed class Health
    {
        public float MaxHealth { get; }
        public float CurrentHealth { get; private set; }
        public Health(float max, float current)
        {
            MaxHealth = max;
            CurrentHealth = current; 
        }
        public void ChangeCurrentHealth(float hp)
        {
            CurrentHealth = hp; 
        }
    }
}

