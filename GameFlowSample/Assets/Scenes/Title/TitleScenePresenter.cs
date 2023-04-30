using VContainer.Unity;


namespace Totekoya
{
    public class TitleScenePresenter : IInitializable
    {
        private TitleSceneModel _model;
        private TitleSceneView _view;


        public TitleScenePresenter(TitleSceneModel model, TitleSceneView view)
        {
            _model = model;
            _view = view;
        }

        public void Initialize()
        {
            _view.Initialize();
        }

        void OnDestroy()
        {
        }
    }


    public class TitleSceneModel
    {
    }
}