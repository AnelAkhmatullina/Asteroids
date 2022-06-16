using UnityEngine;

namespace Asteroids
{
    internal sealed class InputController 
    {
        private readonly Ship _ship;
        private readonly Camera _camera;
        private readonly Transform _transform;

        private float horizontal;
        private float vertical;
        private PlayerMove _playerMove;
        private IRotation _rotation;

        public InputController(Ship ship, Camera camera, Transform transform)
        {
            _ship = ship;
            _camera = camera;
            _transform = transform; 
        }

        public void Update()
        {
            horizontal = Input.GetAxis("Horizontal");
            vertical = Input.GetAxis("Vertical");
            //rotation = new RotationShip(transform); Чем заменить? 

            var direction = Input.mousePosition - _camera.WorldToScreenPoint(_transform.position);
            _ship.Rotation(direction); // это в методичке было в классе Player

            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);  

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration(); 
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _ship.Fire();    
            } 
        }
    }
}


