using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShipWar2D.Abstracts.DataContainers
{
    public interface IPlayerStats
    {
        float MoveSpeed { get; }
        float HorizontalBorder { get; }
        public float VerticalUpBorder { get; }
        public float VerticalDownBorder { get; }
        Sprite[] Sprites { get; }
    }
}

