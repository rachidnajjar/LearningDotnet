using HelloEasyConsole.Pages.Commerce;
using HelloEasyConsole.Pages.Engagement;
using EasyConsole;

namespace HelloEasyConsole.Pages
{
    class MainPage : MenuPage
    {
        public MainPage(Program program)
            : base("Main Page", program,
                  new Option("Commerce", () => program.NavigateTo<PageCommerce>()),
                  new Option("Engagement", () => program.NavigateTo<PageEngagement>()),
                  new Option("Input", () => program.NavigateTo<InputPage>()))
        {
        }
    }
}
