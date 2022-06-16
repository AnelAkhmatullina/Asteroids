using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Asteroids
{
    internal sealed class GameController : MonoBehaviour    
    {    
        private Reference _reference;
        private Text _hpText; 
        private InputController _inputController;
        private Camera _camera;
        private Ship _ship;
        private RotationShip _rotationShip;
        private PlayerHealth _playerHealth; 

        private IMove _playerMove;
        private IRotation _rotation;  

        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp; 
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private GameObject _player; 
        [SerializeField] private Button _restartButton; 

        public void Start()
        {

            EnemyManager.CreateAsteroidEnemy(100.0f);
            IEnemyFactory factory = new AsteroidsFactory();
            factory.Create(100.0f); 
            EnemyManager.Factory = factory;
            EnemyManager.Factory.Create(100.0f);
             
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("tie");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
        }

        private void Awake()
        {
            _reference = new Reference();
            _camera = Camera.main;
            _playerMove = new AccelerationMove(transform, _speed, _acceleration);
            _rotation = new RotationShip(transform); 
        }

        public void Update()  
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _rotation.Rotation(direction);
            _playerMove.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);
        }

        private void RestartGame()
        {
            SceneManager.LoadScene(0);  
        }

        //private void GameOverEnd()
        //{
        //    if (_currentHealth <= 0)
        //    {
        //        _viewEndGame.GameOver(_hpText.text);
        //        _restartButton.gameObject.SetActive(true);
        //        Time.timeScale = 0f;

        //    } 
        //}  
    }
}
