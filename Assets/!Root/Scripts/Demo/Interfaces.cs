using System.Collections.Generic;
using UnityEngine;

namespace LearnVContainer
{
    public interface IInput
    {
        bool Up { get;}
        bool Down { get;}
        bool Left { get;}
        bool Right { get;}
        bool Attack { get;}
    }

    public interface IMovement
    {
        void MoveUp(Transform transform, float speed);
        void MoveDown(Transform transform, float speed);
        void MoveLeft(Transform transform, float speed);
        void MoveRight(Transform transform, float speed);
    }

    public interface IRotate
    {
        void RotateUp(List<Transform> piecesNormal, Transform pieceCenter);
        void RotateDown(List<Transform> piecesNormal, Transform pieceCenter);
        void RotateLeft(List<Transform> piecesNormal, Transform pieceCenter);
        void RotateRight(List<Transform> piecesNormal, Transform pieceCenter);
    }

    public interface IShoot
    {
        void BasicAttack(Direction direction, Vector3 shootPoint, IBullet bullet, float force);
    }

    public interface IBullet
    {
        Rigidbody2D Rb { get;}
    }
}
