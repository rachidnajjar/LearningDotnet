using HelloEasyConsole.Pages.Commerce.Courtier;
using HelloEasyConsole.Pages.Commerce.GroupeCourtier;
using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce
{
    class PageCommerce : MenuPage
    {
        public PageCommerce(Program program)
            : base("Commerce", program,
                  new Option("Groupe de courtier", () => program.NavigateTo<PageGroupeCourtier>()),
                  new Option("Courtier", () => program.NavigateTo<PageCourtier>()))
        {
        }
    }
}
