using VContainer;
using VContainer.Unity;


namespace Totekoya
{
    public class SubGameScenePresenter : IInitializable
    {
        private SubGameSceneModel _model;
        private SubGameSceneView _view;


        [Inject]
        public SubGameScenePresenter(SubGameSceneModel model, SubGameSceneView view)
        {
            _model = model;
            _view = view;
        }

        public void Initialize()
        {
            _view.Initialize();
        }
    }


    public class SubGameSceneModel
    {
    }
}