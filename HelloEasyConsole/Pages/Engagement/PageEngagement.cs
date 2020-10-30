using EasyConsole;

namespace HelloEasyConsole.Pages.Engagement
{
    class PageEngagement : Page
    {
        public PageEngagement(Program program)
            : base("Engagement", program)
        {
        }

        public override void Display()
        {
            base.Display();

            Output.WriteLine("Hello from Page Engagement");

            Input.ReadString("Press [Enter] to navigate home");
            Program.NavigateHome();
        }
    }
}
