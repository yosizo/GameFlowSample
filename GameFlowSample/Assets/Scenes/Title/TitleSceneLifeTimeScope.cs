using UnityEngine;
using VContainer;
using VContainer.Unity;


namespace Totekoya
{
    public class TitleSceneLifeTimeScope : LifetimeScope
    {
        [SerializeField]
        private TitleSceneView view;


        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<TitleSceneModel>(Lifetime.Singleton);
            builder.RegisterComponent<TitleSceneView>(view);

            builder.RegisterEntryPoint<TitleScenePresenter>(Lifetime.Singleton);
        }
    }
}