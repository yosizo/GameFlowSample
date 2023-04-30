using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;
using MessagePipe;


namespace Totekoya
{
    public class MainGameSceneView : MonoBehaviour, IInitializable
    {
        [SerializeField]
        private Button _button;

        [Inject]
        private IPublisher<GameFlowManager.SceneChangeData> _publisher { get; set; }


        public void Initialize()
        {
            _button.onClick.RemoveAllListeners();
            _button.onClick.AddListener(OnClickButton);
        }

        public void OnClickButton()
        {
            _publisher.Publish(new GameFlowManager.SceneChangeData()
            {
                sceneName = "Title"
            });
        }

        private void OnDestroy()
        {
        }
    }
}