using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce.GroupeCourtier
{
    class PageListerGroupeCourtier : Page
    {
        public PageListerGroupeCourtier(Program program)
            : base("Lister les groupes de courtier", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Traitement permettant de lister les groupes de courtier");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
