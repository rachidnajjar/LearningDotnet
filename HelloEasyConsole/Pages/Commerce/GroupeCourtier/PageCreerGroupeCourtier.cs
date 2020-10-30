using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce.GroupeCourtier
{
    class PageCreerGroupeCourtier : Page
    {
        public PageCreerGroupeCourtier(Program program)
            : base("Créer un groupe de courtier", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Traitement permettant de créer un groupe de courtier");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
