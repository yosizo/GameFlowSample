using UnityEngine;
using UnityEngine.UI;
using VContainer;
using MessagePipe;
using VContainer.Unity;
using MemoryPack;


namespace Totekoya
{
    public class TitleSceneView : MonoBehaviour, IInitializable
    {
        [SerializeField]
        private Button _button_main;

        [SerializeField]
        private Button _button_sub;

        [Inject]
        private IPublisher<GameFlowManager.SceneChangeData> _publisher { get; set; }


        public void Initialize()
        {
            var v = new MemoryPackTestData();
            v.age = 100;
            v.Name = "hoge";
            v.weight = 123.45f;
            // シリアライズ
            var bin = MemoryPackSerializer.Serialize(v);
            // デシリアライズ
            var val = MemoryPackSerializer.Deserialize<MemoryPackTestData>(bin);

            _button_main.onClick.RemoveAllListeners();
            _button_sub.onClick.RemoveAllListeners();
            _button_main.onClick.AddListener(OnClickButtonMain);
            _button_sub.onClick.AddListener(OnClickButtonSub);
        }

        public void OnClickButtonMain()
        {
            _publisher.Publish(new GameFlowManager.SceneChangeData()
            {
                sceneName = "MainGame"
            });
        }

        public void OnClickButtonSub()
        {
            _publisher.Publish(new GameFlowManager.SceneChangeData()
            {
                sceneName = "SubGame"
            });
        }

        private void OnDestroy()
        {
        }
    }
}