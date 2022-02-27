using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipWar2D.Abstracts.Movements
{
    public interface IMover
    {
        void Tick();

        void FixedTick();
    }
}

