using SpaceShipWar2D.Abstracts.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShipWar2D.Controllers.Movements
{
    
    public class PlayerTransformMovement : IMover
    {
        PlayerController _playerController;
        Vector2 _direction;

        public PlayerTransformMovement(PlayerController playerController)
        {
            _playerController = playerController;
        }

        public void Tick()
        {
            _direction = _playerController.InputReader.Direction;
        }

        public void FixedTick()
        {
            //yurutme
            _playerController.transform.position += (Vector3)_direction * Time.deltaTime;
        }
    }

}
