using SpaceShipWar2D.Abstracts.Inputs;
using SpaceShipWar2D.Abstracts.Movements;
using SpaceShipWar2D.Controllers.Movements;
using SpaceShipWar2D.Inputs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace SpaceShipWar2D.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        IMover _mover;

        public IInputReader InputReader { get; private set; }
        
        //Vector2 _direction;
        
        //Rigidbody2D _rigidBody;

        private void Awake()
        {
            // eski input sistemde çalýþtýrýlýp yeni input sisteme çaliþma zamaný geçirmek için yazýlan kod
            //inputReader = new OldInputReader(); 
            InputReader = new NewInputReader();
            //_rigidBody = GetComponent<Rigidbody2D>();
            _mover = new PlayerTransformMovement(this);
        }
        //private void Update()
        //{
        //    Debug.Log(_inputReader.Direction);
        //}

        //[ContextMenu(nameof(SetNewInput))]
        //public void SetNewInput()
        //{
        //    _inputReader = new NewInputReader();
        //}

        private void Update()
        {
            //_direction = _inputReader.Direction;
            //Debug.Log(_direction);
            _mover.Tick();
        }
        private void FixedUpdate()
        {
            //this.transform.position += (Vector3)_direction * Time.deltaTime;
            //this.transform.Translate(_direction);
            //_rigidBody.velocity = _direction*Time.deltaTime;
            _mover.FixedTick();
        }
    }
}

