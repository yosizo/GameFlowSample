using UnityEngine;
using UnityEngine.UI;
using VContainer;
using MessagePipe;
using VContainer.Unity;

namespace Totekoya
{
    public class SubGameSceneView : MonoBehaviour
    {
        [SerializeField]
        private Button _button;
        private int cnt;

        private void Start()
        {
            var subscriber = GlobalMessagePipe.GetSubscriber<int>();
            subscriber.Subscribe(data =>
            {
                Debug.Log("subscribe:" + data);
            });
        }

        public void OnClickButton()
        {
            var pub = GlobalMessagePipe.GetPublisher<int>();
            pub.Publish(cnt++);
        }
    }
}