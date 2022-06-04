using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Asteroids
{
    internal sealed class GameController : MonoBehaviour  
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private float _hp;
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private GameObject _player;
        [SerializeField] private Button _restartButton;
        //private ViewBonus _viewBonus;
        //private ViewEndGame _viewEndGame;
        private Reference _reference;
        private Text _hpText; 
        private InputController _inputController;
        private Camera _camera;
        private Ship _ship;

        private IMove _playerMove; 
        //private PlayerMove _playerMove; ???

        public void Start()
        {
            _playerMove = new AccelerationMove(transform, _speed, _acceleration);
            //_playerMove = new PlayerMove(transform, _speed); ???
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _speed,
            _acceleration);
            var rotation = new RotationShip(Vector3 direction);  //как исправить? 
            _ship = new Ship(moveTransform, rotation); 
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
        //    if (_hp <= 0)
        //    {
        //        _viewEndGame.GameOver(_hpText.text);
        //        _restartButton.gameObject.SetActive(true);
        //        Time.timeScale = 0f;

        //    }
        //}  
    }   
}
