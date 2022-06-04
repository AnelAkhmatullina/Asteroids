using UnityEngine;

namespace Asteroids
{
    internal class PlayerMove: IMove 
    {
        [SerializeField] Rigidbody2D _rigidbody2D;  
        private readonly Transform _transform;
        private Vector3 _move;

        public float Speed { get; protected set; } 

        public PlayerMove(Transform transform, float speed) 
        {
            _transform = transform;  
            Speed = speed;  
        }

        public void Move(float x, float y, float z) 
        {    
            if (_rigidbody2D)
            {
                _rigidbody2D.AddForce(new Vector3(x, y, z) * Speed);  
            }
            else
            {
                Debug.Log("NO Rigidbody");
            }
        }  
    } 
}


