using SpaceShipWar2D.Abstracts.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SpaceShipWar2D.Inputs
{
    public class NewInputReader : IInputReader
    {
        public Vector2 Direction { get; private set; }

        public NewInputReader()
        {
            GameInput gameInput = new GameInput();
            gameInput.Player.Movement.performed += HandleOnMovement;
            gameInput.Player.Movement.canceled += HandleOnMovement;
            gameInput.Enable();
        }

        void HandleOnMovement(InputAction.CallbackContext context)
        {
            Direction = context.ReadValue<Vector2>();
        }
    }
}


