using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public sealed class SaucerFire : IFire
    {
        private readonly Rigidbody2D _prefabBullet;
        private readonly IViewServices _viewServices;

        public SaucerFire(Rigidbody2D prefabBullet, IViewServices viewServices)
        {          
            _prefabBullet = prefabBullet;
            _viewServices = viewServices;
        }

        public void Fire()
        {
            var bullet = _viewServices.Instantiate<Rigidbody2D>(_prefabBullet.gameObject);
            bullet.AddForce(Vector3.forward);
            _viewServices.Destroy(bullet.gameObject); 
        }
    }
}
