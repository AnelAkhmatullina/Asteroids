using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class ProviderPlayer : MonoBehaviour
    {
        public event Action<string> OnCollisionEnterChange;

        private void OnCollisionEnter(Collision collision)
        {
            OnCollisionEnterChange?.Invoke(gameObject.name);
        }
    } 
}


