using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerFire: IFire
    {
        private readonly Rigidbody2D _bulletGreen; // пуля
        [SerializeField] private Sprite _sprite; 
        private readonly Transform _barrel; // ствол 
        private readonly float _force; // сила оружия
        
        public void CreateBullet()
        {
            var gameObjectBuilder = new GameObjectBuilder();
            GameObject _bulletGreen = gameObjectBuilder.
                Visual.
                Name("Bullet Green"). 
                Sprite(_sprite).
                Physics.
                BoxCollider2D(); 
        }

        public PlayerFire(Rigidbody2D bulletGreen, Transform barrel, float force)
        {
            _bulletGreen = bulletGreen;
            _barrel = barrel;
            _force = force;
        }  

        public void Fire()   
        {
            
            var temAmmunition = Object.Instantiate(_bulletGreen, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }

    }
}
