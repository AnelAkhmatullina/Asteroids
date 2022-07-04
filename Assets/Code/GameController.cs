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
        private SaucerFire _saucerFire; 
        private IViewServices _viewServices;
        private Rigidbody2D _prefabBullet;  


        private IMove _playerMove;
        private IRotation _rotation;
        private IFire _fire; 

        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;       
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private GameObject _player;  
        [SerializeField] private Button _restartButton; 

        public void Start()
        {

            EnemyManager.CreateAsteroidEnemy(100.0f);
            IEnemyFactory factory = new AsteroidsFactory();
            factory.Create(100.0f);   
            //EnemyManager.Factory = factory;
            //EnemyManager.Factory.Create(100.0f);
            

            
        }

        private void Awake()
        {
            _reference = new Reference();           
            _camera = Camera.main;
            _playerMove = new AccelerationMove(transform, _speed, _acceleration);
            _rotation = new RotationShip(transform);
            _ship = new Ship(_playerMove, _rotation, _fire);
            _saucerFire = new SaucerFire(_prefabBullet, _viewServices);
            _viewServices = new ViewServices();
            _inputController = new InputController(_ship, _camera, transform); 
            
        }

        public void Update()  
        {
            _inputController.Update(); 
        }

        private void RestartGame()
        {
            SceneManager.LoadScene(0);  
        }

        //private void GameOverEnd()
        //{
        //    if (_hp <= 0)
        //    {
        //        _viewEndGame.GameOver(_hpText.text);
        //        _restartButton.gameObject.SetActive(true);
        //        Time.timeScale = 0f;

        //    }
        //}
    }
}
