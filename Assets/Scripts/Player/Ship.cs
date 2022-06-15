using UnityEngine;

namespace Asteroids
{
    internal sealed class Ship: IMove, IRotation, IFire
    {
        private readonly IMove _moveImplemenation;
        private readonly IRotation _rotationImplementation;

        public float Speed => _moveImplemenation.Speed;

        public Ship(IMove moveImplemenation, IRotation rotationImplementation)
        {
            _moveImplemenation = moveImplemenation;
            _rotationImplementation = rotationImplementation; 
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveImplemenation.Move(horizontal, vertical, deltaTime); 
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplementation.Rotation(direction);
        }

        public void AddAcceleration()
        {
            if (_moveImplemenation is AccelerationMove accelerationMove) // ????????????
            {
                accelerationMove.AddAcceleration(); 
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplemenation is AccelerationMove accelerationMove) // ????????????
            {
                accelerationMove.RemoveAcceleration();
            }
        }

        public void Fire()
        {

        }
    } 
}

