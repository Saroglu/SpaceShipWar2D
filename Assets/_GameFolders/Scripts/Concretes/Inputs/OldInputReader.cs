using SpaceShipWar2D.Abstracts.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipWar2D.Inputs
{
    public class OldInputReader : IInputReader
    {
     
        public Vector2 Direction
        {
            get
            {
                float x = Input.GetAxis("Horizontal");
                float y = Input.GetAxis("Vertical");
                
                Vector2 direction = new Vector2(x, y);
                return direction;
            }
        }

    }
}

