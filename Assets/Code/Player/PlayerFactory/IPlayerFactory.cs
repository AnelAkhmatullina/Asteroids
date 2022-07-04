using UnityEngine;

namespace Asteroids 
{
    public interface IPlayerFactory
    {
        Transform CreatePlayer();
    }
}
