using System;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using VContainer.Unity;
using Cysharp.Threading.Tasks;
using MessagePipe;
using System.Linq;


namespace Totekoya
{
    /// <summary>
    /// ゲーム全体の画面遷移を管理するクラス
    /// 現状ではシーンロードのみ
    /// 
    /// ※今後、以下のような機能が必要になると考えられる
    /// - 遷移時のトランジション
    /// - 遷移履歴
    /// - 状況別遷移先選定
    /// - エラー発生時の強制遷移
    /// - Androidバックキー対応
    /// </summary>
    public class GameFlowManager : IInitializable
    {
        public class SceneChangeData
        {
            public string sceneName;
        }

        public enum SceneType
        {
            Unknown,
            Splash,
            Title,
            MainGame,
            SubGame
        }

        private readonly Dictionary<SceneType, string> _sceneTypeName =new Dictionary<SceneType, string>
        {
            [SceneType.Unknown] = "",
            [SceneType.Splash] = "Splash",
            [SceneType.Title] = "Title",
            [SceneType.MainGame] = "MainGame",
            [SceneType.SubGame] = "SubGame",
        };


        private SceneType _currentSceneType;
        private ISubscriber<SceneChangeData> _subscriber { get; set; }
        private IDisposable disposable;


        public GameFlowManager(ISubscriber<SceneChangeData> sub)
        {
            _subscriber = sub;
        }

        public void Initialize()
        {
            _currentSceneType = SceneType.Unknown;

            var dbag = DisposableBag.CreateBuilder();

            // シーン遷移イベントを購読
            _subscriber.Subscribe(data =>
            {
                SceneChange(data.sceneName).Forget();

            }).AddTo(dbag);

            disposable = dbag.Build();

            // 初回ロードシーン
            SceneChange(SceneType.Splash).Forget();
        }

        void OnDestroy()
        {
            disposable.Dispose();
        }


        public string GetSceneName(SceneType scene)
        {
            _sceneTypeName.TryGetValue(scene, out var name);
            return name;
        }

        public SceneType GetSceneType(string name)
        {
            return _sceneTypeName.FirstOrDefault(item => item.Value == name).Key;
        }

        public async UniTask SceneChange(SceneType scene)
        {
            await SceneChange(GetSceneName(scene));
        }

        public async UniTask SceneChange(string name)
        {
            await SceneManager.LoadSceneAsync(name);
            _currentSceneType = GetSceneType(name);
        }
    }
}