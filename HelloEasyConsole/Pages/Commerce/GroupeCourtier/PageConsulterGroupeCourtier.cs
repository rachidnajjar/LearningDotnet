using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce.GroupeCourtier
{
    class PageConsulterGroupeCourtier : Page
    {
        public PageConsulterGroupeCourtier(Program program)
            : base("Consulter un groupe de courtier", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Traitement permettant de consulter un groupe de courtier");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
