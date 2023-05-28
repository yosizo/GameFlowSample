using MessagePipe;
using VContainer;
using VContainer.Unity;
using UnityEngine;


namespace Totekoya
{
    public class SubGameScenePresenter : MonoBehaviour
    {
        //private SubGameSceneModel _model;
        //private SubGameSceneView _view;


        //[Inject]
        //public SubGameScenePresenter(SubGameSceneModel model, SubGameSceneView view)
        //{
        //    _model = model;
        //    _view = view;
        //}

        public void Start()
        {
//            _view.Initialize();
            var subscriber = GlobalMessagePipe.GetSubscriber<int>();
            subscriber.Subscribe(data =>
            {
                Debug.Log("subscribe:" + data);
            });

        }
    }


    public class SubGameSceneModel
    {
    }
}