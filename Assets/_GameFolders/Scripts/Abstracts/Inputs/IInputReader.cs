using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipWar2D.Abstracts.Inputs
{
    public interface IInputReader 
    {
        Vector2 Direction { get; }
    }
}

