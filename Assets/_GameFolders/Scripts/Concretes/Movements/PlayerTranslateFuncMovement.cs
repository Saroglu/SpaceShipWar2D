using SpaceShipWar2D.Abstracts.Movements;
using SpaceShipWar2D.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTranslateFuncMovement : IMover
{
    readonly PlayerController _playerController;

    Vector2 _direction;

    public PlayerTranslateFuncMovement(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void Tick()
    {
        _direction = _playerController.InputReader.Direction;
    }

    public void FixedTick()
    {
        _playerController.transform.Translate(_direction);
    }
}
