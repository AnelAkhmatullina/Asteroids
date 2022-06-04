using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerFire
    {
        private readonly Rigidbody2D _bullet; // пуля
        private readonly Transform _barrel; // ствол
        private readonly float _force; // сила оружия

        public PlayerFire(Rigidbody2D bullet, Transform barrel, float force) //почему это название и название класса должны совпадать? 
        {
            _bullet = bullet;
            _barrel = barrel; 
            _force = force; 
        }

        public void Fire()
        {
            if (Input.GetButtonDown("Fire1")) 
            {
                var temAmmunition = Instantiate(_bullet, _barrel.position, _barrel.rotation);
                temAmmunition.AddForce(_barrel.up * _force);
            }
        } 
    }
}
