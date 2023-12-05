using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LearnVContainer
{
    public class Shooter : IShoot
    {
        public void BasicAttack(Direction direction, Vector3 shootPoint, IBullet bullet, float force)
        {
            switch (direction)
            {
                case Direction.Up:
                    bullet.Rb.AddForce(force * Vector2.up);
                    break;
                case Direction.Down:
                    bullet.Rb.AddForce(force * Vector2.down);
                    break;
                case Direction.Left:
                    bullet.Rb.AddForce(force * Vector2.left);
                    break;
                case Direction.Right:
                    bullet.Rb.AddForce(force * Vector2.right);
                    break;
            }
        }
    }
}
