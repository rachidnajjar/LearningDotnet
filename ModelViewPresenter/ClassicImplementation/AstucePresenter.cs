using System;

namespace ClassicImplementation
{
    public class AstucePresenter
    {
        private IAstuceView viewer;
        private int astuceCourant;

        public AstucePresenter(IAstuceView view)
        {
            viewer = view;
            astuceCourant = 0; //normalement valeur random
            viewer.Astuce = getAstuceDuJour();
            viewer.CloseRequested += OnCloseRequested;
            viewer.NextRequested += OnNextRequested;
        }

        private string getAstuceDuJour()
        {
            // Pour l'exemple, il n'y en a que 2.
            if (astuceCourant == 0)
            {
                astuceCourant++;
                return "Les patterns sont un moyen d'économiser du temps";
            }
            else
            {
                astuceCourant = 0;
                return "Utilisez le modèle View presenter pour mieux valider votre application par des tests unitaires";
            }
        }

        private void OnCloseRequested(object sender, EventArgs e)
        {
            viewer.Close();
        }

        private void OnNextRequested(object sender, EventArgs e)
        {
            viewer.Astuce = getAstuceDuJour();
        }
    }
}