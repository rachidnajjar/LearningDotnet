using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce.GroupeCourtier
{
    class PageSupprimerGroupeCourtier : Page
    {
        public PageSupprimerGroupeCourtier(Program program)
            : base("Supprimer un groupe de courtier", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Traitement permettant de supprimer un groupe de courtier");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
