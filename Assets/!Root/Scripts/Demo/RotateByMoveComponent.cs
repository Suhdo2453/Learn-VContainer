using System;
using System.Collections.Generic;
using UnityEngine;

namespace LearnVContainer
{
    public class RotateByMoveComponent : IRotate
    {
        public void RotateUp(List<Transform> piecesNormal, Transform pieceCenter)
        {
            for (int i = 0; i < piecesNormal.Count; i++)
            {
                var newPosition = pieceCenter.position;
                if (i == 0)
                {
                    newPosition.x -= 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    // directionsData.Add(Direction.Left, piecesNormal[i]);
                }//
                else if (i == 1)
                {
                    newPosition.y += 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Up, piecesNormal[i]);
                }
                else if (i == 2)
                {
                    newPosition.x += 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Right, piecesNormal[i]);
                }
            }
        }
        
        public void RotateDown(List<Transform> piecesNormal, Transform pieceCenter)
        {
            for (int i = 0; i < piecesNormal.Count; i++)
            {
                var newPosition = pieceCenter.position;
                if (i == 0)
                {
                    newPosition.x -= 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Left, piecesNormal[i]);
                }
                else if (i == 1)
                {
                    newPosition.y -= 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Up, piecesNormal[i]);
                }
                else if (i == 2)
                {
                    newPosition.x += 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Right, piecesNormal[i]);
                }
            }
        }
        
        public void RotateLeft(List<Transform> piecesNormal, Transform pieceCenter)
        {
            for (int i = 0; i < piecesNormal.Count; i++)
            {
                var newPosition = pieceCenter.position;
                if (i == 0)
                {
                    newPosition.y -= 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Left, piecesNormal[i]);
                }
                else if (i == 1)
                {
                    newPosition.x -= 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Up, piecesNormal[i]);
                }
                else if (i == 2)
                {
                    newPosition.y += 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Right, piecesNormal[i]);
                }
            }
        }
        
        public void RotateRight(List<Transform> piecesNormal, Transform pieceCenter)
        {
            for (int i = 0; i < piecesNormal.Count; i++)
            {
                var newPosition = pieceCenter.position;
                if (i == 0)
                {
                    newPosition.y += 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Left, piecesNormal[i]);
                }
                else if (i == 1)
                {
                    newPosition.x += 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Up, piecesNormal[i]);
                }
                else if (i == 2)
                {
                    newPosition.y -= 1;
                    if(newPosition == piecesNormal[i].position) continue;
                    piecesNormal[i].position = newPosition;
                    //directionsData.Add(Direction.Right, piecesNormal[i]);
                }
            }
        }
    }
}