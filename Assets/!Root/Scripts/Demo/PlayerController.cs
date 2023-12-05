using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LearnVContainer
{
        public class PlayerController : MonoBehaviour
        {
            [Inject] private readonly IInput _input;
            [Inject] private readonly IShoot _shoot;
            [Inject] private readonly PlayerView _playerView;
            
            private Direction _currentDirection;
            
            public void Update()
            {
                if(_input.Attack) _shoot.BasicAttack();
                
                if (_input.Up)
                {
                    _currentDirection = Direction.Up;
                    _playerView.MoveUp();
                    _playerView.RotateUp();
                }
                else if (_input.Down)
                {
                    _currentDirection = Direction.Down;
                    _playerView.MoveDown();
                    _playerView.RotateDown();
                }
                else if (_input.Left)
                {
                    _currentDirection = Direction.Left;
                    _playerView.MoveLeft();
                    _playerView.RotateLeft();
                }
                else if (_input.Right)
                {
                    _currentDirection = Direction.Right;
                    _playerView.MoveRight();
                    _playerView.RotateRight();
                }
            }
        }
}
