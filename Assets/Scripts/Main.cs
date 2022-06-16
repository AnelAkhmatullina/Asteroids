using UnityEngine;

namespace Asteroids
{
    public sealed class Main : MonoBehaviour
    {
        private GameController _gameController;

        private void Start()
        {        
            _gameController = gameObject.AddComponent<GameController>();  
        }

        private void Update()
        {
            _gameController.Update();   
        }
    } 
}

