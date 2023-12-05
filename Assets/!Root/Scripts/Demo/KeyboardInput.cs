using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LearnVContainer
{
    public class KeyboardInput : ITickable, IInput
    {
        private bool _up;
        private bool _down;
        private bool _right;
        private bool _left;
        private bool _attack;

        public bool Up => _up;
        public bool Down => _down;
        public bool Left => _left;
        public bool Right => _right;
        public bool Attack => _attack;

        public void Tick()
        {
            _up = Input.GetKey(KeyCode.UpArrow);
            _down = Input.GetKey(KeyCode.DownArrow);
            _left = Input.GetKey(KeyCode.LeftArrow);
            _right = Input.GetKey(KeyCode.RightArrow);
            _attack = Input.GetKeyDown(KeyCode.Space);
        }
    }
}
