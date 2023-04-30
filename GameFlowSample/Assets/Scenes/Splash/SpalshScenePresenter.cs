using UnityEngine;
using VContainer;
using VContainer.Unity;
using Cysharp.Threading.Tasks;


namespace Totekoya
{
    public class SplashScenePresenter : IInitializable
    {
        private GameFlowManager _gameFlowManager;


        [Inject]
        private SplashScenePresenter(GameFlowManager gameFlowManager)
        {
            _gameFlowManager = gameFlowManager;
        }

        public void Initialize()
        {
            InitializeInternal();
        }

        private async void InitializeInternal()
        {
            await UniTask.Delay(3000);

            await _gameFlowManager.SceneChange("Title");
        }
    }
}