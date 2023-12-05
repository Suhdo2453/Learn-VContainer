using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;

namespace LearnVContainer
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Transform pieceCenter;
        [SerializeField] private List<Transform> piecesNormal;
        [SerializeField] private Direction defaultDirection;
        [SerializeField] private float speed = 10f;
        [SerializeField] private Transform _shootpoint;

        [Inject]
        private readonly IRotate _rotateService;
        [Inject]
        private readonly IMovement _movementService;

        private void Start()
        {
            SetDefaultPieces();
        }

        public void SetDefaultPieces()
        {
            switch (defaultDirection)
            {
                default:
                case Direction.Up:
                    RotateUp();
                    break;
                case Direction.Down:
                    RotateDown();
                    break;
                case Direction.Left:
                    RotateLeft();
                    break;
                case Direction.Right:
                    RotateRight();
                    break;
            }
        }

        #region Rotate

        public void RotateUp()
        {
            _rotateService.RotateUp(piecesNormal, pieceCenter);
        }
        
        public void RotateDown()
        {
            _rotateService.RotateDown(piecesNormal, pieceCenter);
        }
        
        public void RotateLeft()
        {
            _rotateService.RotateLeft(piecesNormal, pieceCenter);
        }
        
        public void RotateRight()
        {
            _rotateService.RotateRight(piecesNormal, pieceCenter);
        }

        #endregion

        #region Move

        public void MoveUp()
        {
            _movementService.MoveUp(transform, speed * Time.deltaTime);
        }
        
        public void MoveDown()
        {
            _movementService.MoveDown(transform, speed * Time.deltaTime);
        }
        
        public void MoveLeft()
        {
            _movementService.MoveLeft(transform, speed * Time.deltaTime);
        }
        
        public void MoveRight()
        {
            _movementService.MoveRight(transform, speed * Time.deltaTime);
        }

        #endregion
    }
}
