using System;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ShipView : MonoBehaviour
    {
        public event Action OnCollisionEnter;

        private void OnCollisionEnter2D(Collision2D other)
        {
            OnCollisionEnter?.Invoke(); 
        }
    } 
}
 

 