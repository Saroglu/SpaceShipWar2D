using SpaceShipWar2D.Abstracts.Animations;
using SpaceShipWar2D.Abstracts.Combats;
using SpaceShipWar2D.Abstracts.Controllers;
using SpaceShipWar2D.Abstracts.DataContainers;
using SpaceShipWar2D.Abstracts.Inputs;
using SpaceShipWar2D.Abstracts.Movements;
using SpaceShipWar2D.Animations;
using SpaceShipWar2D.Inputs;
using SpaceShipWar2D.ScriptableObjects;
using SpaceShipWarBa.Movements;
using UnityEngine;

namespace SpaceShipWar2D.Controllers
{
    public class PlayerController : MonoBehaviour,IPlayerController
    {
        [SerializeField] PlayerStatsSO _stats;

        IMover _mover;
        IAnimation _animation;
        IHealth _health;

        public IInputReader InputReader { get; private set; }
        public IPlayerStats Stats => _stats;

        void Awake()
        {
            #region IInputReader ornek anlatim icin

            //eski input systemde calistirip yeni input sisteme calisma zamani gecirmek icin yazilmis bir ornek
            //_inputReader = new OldInputReader();

            #endregion

            InputReader = new NewInputReader();
            //burdaki this anlami bu class'in kendisi demektir
            _mover = new PlayerTranslateFuncMovement(this);
            _animation = new PlayerAnimation(this);
        }

        void Update()
        {
            _mover.Tick();
        }

        void FixedUpdate()
        {
            //yurume islemlerini yapiyoruz fizik
            _mover.FixedTick();
        }

        void LateUpdate()
        {
            _animation.LateTick();
        }

        #region IInputReader ornek anlatim

        //calisma zmaamni eski input sistemden yeni input sisteme gecirdik yazdigimz kod bu kadar esnek bir yapidir
        // [ContextMenu(nameof(SetNewInput))]
        // public void SetNewInput()
        // {
        //     _inputReader = new NewInputReader();
        // }

        #endregion
    }
}

