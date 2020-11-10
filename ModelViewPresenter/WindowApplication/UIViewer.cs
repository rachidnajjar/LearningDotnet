using UIPresenter;

namespace WindowApplication
{
    public class UIViewer : IViewer
    {
        public Presenter Presenter { get; private set; }

        public UIViewer()
        {
            this.Presenter = new Presenter(this);
        }

        public void Start()
        {
            this.Presenter.Start();
        }

        public void CallDisplayUserProfile()
        {
            DisplayInfoWindow win = new DisplayInfoWindow();
            win.Code = this.Presenter.Code;
            win.Nom = this.Presenter.Nom;
            win.Prenom = this.Presenter.Prenom;
            win.Type = this.Presenter.Type;
            win.Show();
        }

        public void CallRequestUserCode()
        {
            CodeRequestWindow win = new CodeRequestWindow(this);
            win.Show();
        }
    }
}