using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Totekoya
{
    public class MainGameSceneLifeTimeScope : LifetimeScope
    {
        [SerializeField]
        private MainGameSceneView view;


        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<MainGameSceneModel>(Lifetime.Singleton);
            builder.RegisterComponent<MainGameSceneView>(view);

            builder.RegisterEntryPoint<MainGameScenePresenter>(Lifetime.Singleton);
        }
    }
}