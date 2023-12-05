using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer.Unity;

namespace LearnVContainer
{
    public class Bullet : MonoBehaviour, IBullet
    {
        public Rigidbody2D Rb { get; private set; }

        private void Awake()
        {
            Rb = GetComponent<Rigidbody2D>();
        }
    }
}
