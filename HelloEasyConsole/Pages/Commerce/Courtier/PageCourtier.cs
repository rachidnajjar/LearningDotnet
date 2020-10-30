using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce.Courtier
{
    class PageCourtier : Page
    {
        public PageCourtier(Program program)
            : base("Courtier", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page Courtier");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
