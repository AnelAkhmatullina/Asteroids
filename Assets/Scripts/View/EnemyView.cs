using System;
using UnityEngine;

namespace Asteroids
{
    public sealed class EnemyView : MonoBehaviour
    {
        public event Action OnCollisionEnter;

        private void OnCollisionEnter2D(Collision2D other)
        {
            OnCollisionEnter?.Invoke(); 
        }
    }
}
