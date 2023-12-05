using UnityEngine;

namespace LearnVContainer
{
    public class MoveTransform : IMovement
    {
        public void MoveUp(Transform transform, float speed)
        {
            var transformPosition = transform.position;
            transformPosition.y += speed;
            transform.position = transformPosition;
        }

        public void MoveDown(Transform transform, float speed)
        {
            var transformPosition = transform.position;
            transformPosition.y -= speed;
            transform.position = transformPosition;
        }

        public void MoveLeft(Transform transform, float speed)
        {
            var transformPosition = transform.position;
            transformPosition.x -= speed;
            transform.position = transformPosition;
        }

        public void MoveRight(Transform transform, float speed)
        {
            var transformPosition = transform.position;
            transformPosition.x += speed;
            transform.position = transformPosition;
        }
    }
}
