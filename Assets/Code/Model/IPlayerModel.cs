using UnityEngine;

namespace Asteroids
{
    public interface IPlayerModel
    {
        public Sprite Sprite { get; }
        public float Speed { get; }
        public Vector2Int Position { get; }
        public string Name { get; }
    }
} 
