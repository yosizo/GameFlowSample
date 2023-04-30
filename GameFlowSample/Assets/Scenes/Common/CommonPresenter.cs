using VContainer;
using VContainer.Unity;


namespace Totekoya
{
    public class CommonPresenter : IInitializable
    {
        GameFlowManager _gameFlowManager;

        [Inject]
        public CommonPresenter(GameFlowManager gameFlowManager)
        {
            _gameFlowManager = gameFlowManager;
        }

        // ゲーム全体を通して存在するオブジェクトの初期化
        public void Initialize()
        {
            // シーン遷移マネージャー
            _gameFlowManager.Initialize();

            // サウンド
            // 広告
            // セーブデータ
            // 通信
            // 。。。あたりはここでやる方が良さそう
        }
    }
}