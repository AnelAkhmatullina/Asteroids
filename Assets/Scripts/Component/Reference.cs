using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{

    public sealed class Reference
    {
        private GameObject _hpLabel;
        private GameObject _endGameLabel;
        private GameObject _restartButton;
        private Canvas _canvas;
        private Camera _mainCamera; 


        public GameObject EndGameLabel
        {
            get
            {
                if (_endGameLabel == null)
                {
                    GameObject endGamePrefab = Resources.Load<GameObject>("UI/EndGame");
                    _endGameLabel = Object.Instantiate(endGamePrefab, Canvas.transform);
                }
                return _endGameLabel;
            }

            set => _endGameLabel = value;
        }

        public GameObject RestartButton
        {
            get
            {
                if (_restartButton == null)
                {
                    GameObject restartButtonPrefab = Resources.Load<GameObject>("UI/RestartButton");
                    _restartButton = Object.Instantiate(restartButtonPrefab, Canvas.transform);
                }
                return _restartButton;
            }

            set => _restartButton = value;
        }

        public Canvas Canvas
        {
            get
            {
                if (_canvas == null)
                {
                    _canvas = Object.FindObjectOfType<Canvas>();
                }
                return _canvas;
            }

            set => _canvas = value;
        }

        public Camera MainCamera
        {
            get
            {
                if (!_mainCamera) // можно не расписывать и указывать без приравнивания к null 
                {
                    _mainCamera = Camera.main;
                }
                return _mainCamera;
            }
            set => _mainCamera = value;
        }
    }
}
