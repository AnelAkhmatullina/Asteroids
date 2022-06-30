using UnityEngine;

namespace Asteroids
{
    [CreateAssetMenu(fileName = "PlayerSettings", menuName = "Data/PlayerSettings")]

    public sealed class PlayerData : ScriptableObject
    {
        public Sprite Sprite;
        [SerializeField] private string _name;
        [SerializeField, Range(0, 100)] private float _hp;
        [SerializeField, Range(0, 100)] private float _speed;
        [SerializeField] private Vector2Int _position;
        public float Hp => _hp;
        public float Speed => _speed;
        public Vector2Int Position => _position;
        public string Name => _name;

    }
}


