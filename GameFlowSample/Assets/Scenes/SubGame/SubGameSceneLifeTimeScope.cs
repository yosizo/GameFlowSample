using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Totekoya
{
    public class SubGameSceneLifeTimeScope : LifetimeScope
    {
        [SerializeField]
        private Transform injectionRoot;

        [SerializeField]
        private SubGameSceneView view;


        // シーン独自の依存関係を記述する
        protected override void Configure(IContainerBuilder builder)
        {
            //builder.Register<SubGameSceneModel>(Lifetime.Singleton);
            //builder.RegisterComponent<SubGameSceneView>(view);

            //builder.RegisterEntryPoint<SubGameScenePresenter>(Lifetime.Singleton);
        }
    }
}