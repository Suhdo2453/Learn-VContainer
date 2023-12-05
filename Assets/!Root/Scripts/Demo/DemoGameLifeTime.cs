using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace LearnVContainer
{
    public class DemoGameLifeTime : LifetimeScope
    {
        [SerializeField] private Bullet _bullet;
        [SerializeField] private PlayerView _playerView;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<IMovement, MoveTransform>(Lifetime.Singleton);
            builder.Register<IRotate, RotateByMoveComponent>(Lifetime.Singleton);
            builder.Register<IInput, KeyboardInput>(Lifetime.Singleton).As<ITickable>();
            builder.Register<IShoot, Shooter>(Lifetime.Singleton);
            builder.RegisterInstance(_bullet);
            builder.RegisterInstance(_playerView);
            builder.Register<PlayerController>(Lifetime.Scoped);
        }
    }
}
