using VContainer.Unity;


namespace Totekoya
{
    public class MainGameScenePresenter : IInitializable
    {
        private MainGameSceneModel _model;
        private MainGameSceneView _view;

        public MainGameScenePresenter(MainGameSceneModel model, MainGameSceneView view)
        {
            _model = model;
            _view = view;
        }

        public void Initialize()
        {
            _view.Initialize();
        }

        public void InitiaslizeInternal(MainGameSceneModel model, MainGameSceneView view)
        {
        }
    }


    public class MainGameSceneModel
    {
    }
}