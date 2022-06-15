using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Asteroids
{
    internal sealed class GameController : MonoBehaviour  
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _currentHealth;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private GameObject _player;
        [SerializeField] private Button _restartButton; 
        
        private Reference _reference;
        private Text _hpText; 
        private InputController _inputController;
        private Camera _camera;
        private Ship _ship;
        private RotationShip _rotationShip;

        // PlayerHealth проинициализировать

        private IMove _playerMove; 
        //почему не private PlayerMove _playerMove; ???

        public void Start()
        {
            _playerMove = new AccelerationMove(transform, _speed, _acceleration);
            //_playerMove = new PlayerMove(transform, _speed); ???
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _speed,
            _acceleration);
            var rotation = new RotationShip();  
            _ship = new Ship(moveTransform, rotation);
            rotation.Rotation(Vector3.forward); // в методичке проверить

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

        private void Update()  
        {
                   
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
