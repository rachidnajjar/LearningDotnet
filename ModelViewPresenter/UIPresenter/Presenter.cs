using System;
using System.Collections.Generic;

namespace UIPresenter
{
    public class Presenter
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }



        private IViewer viewer;

        public Presenter(IViewer viewer)
        {
            this.viewer = viewer;
        }

        public void Start()
        {
            viewer.CallRequestUserCode();
        }

        public List<string> LoadListType()
        {
            List<string> types = new List<string>();
            types.Add("Local");
            types.Add("Domaine");
            return types;
        }

        public bool Validate()
        {
            return (this.Code.Length > 2);
        }

        public void CodeInputEnded()
        {
            loadProfile(this.Code);
            viewer.CallDisplayUserProfile();
        }

        private void loadProfile(string code)
        {
            // TODO call business service
            this.Nom = "Najjar";
            this.Prenom = "Rachid";
        }
    }
}
