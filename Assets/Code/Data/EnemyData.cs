using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


namespace Asteroids
{
    [CreateAssetMenu(fileName = "EnemySettings", menuName = "Data/EnemySettings")]

    public sealed class EnemyData : ScriptableObject
    {
        public Sprite Sprite;
        [SerializeField] private string _name;
        [SerializeField, Range(0, 100)] private float _hp;
        [Range(0, 100)] public float _speed;
        [SerializeField] private Vector2Int _position;
        public float Speed => _speed;
        public float Hp => _hp;
        public Vector2Int Position => _position;
        public string Name => _name;  

    } 
}
