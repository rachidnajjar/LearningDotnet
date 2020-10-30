using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce.GroupeCourtier
{
    class PageModifierGroupeCourtier : Page
    {
        public PageModifierGroupeCourtier(Program program)
            : base("Modifier un groupe de courtier", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Traitement permettant de modifier un groupe de courtier");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
