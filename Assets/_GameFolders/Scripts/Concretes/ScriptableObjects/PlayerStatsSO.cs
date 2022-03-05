using SpaceShipWar2D.Abstracts.DataContainers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceShipWar2D.ScriptableObjects
{

    [CreateAssetMenu(menuName ="Bilge Adam/Stats/Player Stats")]
    public class PlayerStatsSO : ScriptableObject, IPlayerStats
    {
        [Header("Animations")]
        [SerializeField] Sprite[] _sprites;

        [Header("Movements")]
        [SerializeField] float _moveSpeed;
        [SerializeField] float _horizontalBorder = 2f;
        [SerializeField] float _verticalUpBorder = 1f;
        [SerializeField] float _verticalDownBorder = -5f;

        public float MoveSpeed => _moveSpeed;
        public float HorizontalBorder => _horizontalBorder;
        public float VerticalUpBorder => _verticalUpBorder;
        public float VerticalDownBorder => _verticalDownBorder;
        public Sprite[] Sprites => _sprites;
    }
}

