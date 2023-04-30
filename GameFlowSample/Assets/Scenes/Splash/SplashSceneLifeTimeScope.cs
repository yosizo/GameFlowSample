using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Totekoya
{
    public class SplashSceneLifeTimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<SplashScenePresenter>(Lifetime.Singleton);
        }
    }
}