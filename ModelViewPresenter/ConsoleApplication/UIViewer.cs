using System;
using System.Collections.Generic;
using UIPresenter;

namespace ConsoleApplication
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
            Console.WriteLine(string.Format("Utilisateur: {0}", this.Presenter.Code));
            Console.WriteLine(string.Format("  Nom: {0}", this.Presenter.Nom));
            Console.WriteLine(string.Format("  Prénom: {0}", this.Presenter.Prenom));
            Console.WriteLine(string.Format("  Type: {0}", this.Presenter.Type));
            Console.WriteLine("Appuyez sur ENTER pour quitter");
            Console.ReadLine();
        }

        public void CallRequestUserCode()
        {
            loadListTypes(this.Presenter.LoadListType());

            Console.Write("Introduisez le code utilisateur:");
            this.Presenter.Code = Console.ReadLine();

            if (this.Presenter.Validate())
            {
                this.Presenter.CodeInputEnded();
            }
            else
            {
                Console.WriteLine("Données non valides");
                Console.ReadLine();
            }
        }

        private void loadListTypes(List<string> types)
        {
            Console.WriteLine("Tapez le numéro du type choisi:");

            for (int i=0; i<types.Count; i++)
            {
                Console.WriteLine(string.Format("{0} : {1}", i.ToString(), types[i]));
            }

            this.Presenter.Type = types[Convert.ToInt32(Console.ReadLine())];
        }
    }
}