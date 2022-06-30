using UnityEngine;

namespace Asteroids
{
    internal sealed class Ship: IMove, IRotation, IFire
    {
        private readonly IMove _moveImplemenation;
        private readonly IRotation _rotationImplementation;
        private readonly IFire _fireImplementation; 

        public float Speed => _moveImplemenation.Speed;

        public Ship(IMove moveImplemenation, IRotation rotationImplementation, IFire fireImplementation)
        {
            _moveImplemenation = moveImplemenation;
            _rotationImplementation = rotationImplementation;
            _fireImplementation = fireImplementation; 
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveImplemenation.Move(horizontal, vertical, deltaTime); 
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplementation.Rotation(direction);
        }

        public void Fire()
        {
            _fireImplementation.Fire();           
        }

        public void AddAcceleration()
        {
            if (_moveImplemenation is AccelerationMove accelerationMove) 
            {
                accelerationMove.AddAcceleration(); 
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplemenation is AccelerationMove accelerationMove) 
            {
                accelerationMove.RemoveAcceleration();
            }
        }
      
    } 
}

