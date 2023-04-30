using VContainer;
using VContainer.Unity;
using MessagePipe;


namespace Totekoya
{
    public class CommonLifeTimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<GameFlowManager>(Lifetime.Singleton);

            var options = builder.RegisterMessagePipe();
            builder.RegisterMessageBroker<GameFlowManager.SceneChangeData>(options);

            // 共通エントリーポイント
            builder.RegisterEntryPoint<CommonPresenter>(Lifetime.Singleton);
        }
    }
}