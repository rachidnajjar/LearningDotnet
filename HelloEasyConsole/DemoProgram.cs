using HelloEasyConsole.Pages;
using HelloEasyConsole.Pages.Commerce;
using HelloEasyConsole.Pages.Commerce.Courtier;
using HelloEasyConsole.Pages.Commerce.GroupeCourtier;
using HelloEasyConsole.Pages.Engagement;
using EasyConsole;

namespace HelloEasyConsole
{
    class DemoProgram : Program
    {
        public DemoProgram()
            : base("EasyConsole Demo", breadcrumbHeader: true)
        {
            AddPage(new MainPage(this));
            AddPage(new PageCommerce(this));
            AddPage(new PageGroupeCourtier(this));
            AddPage(new PageListerGroupeCourtier(this));
            AddPage(new PageConsulterGroupeCourtier(this));
            AddPage(new PageCreerGroupeCourtier(this));
            AddPage(new PageModifierGroupeCourtier(this));
            AddPage(new PageSupprimerGroupeCourtier(this));
            AddPage(new Page1Ai(this));
            AddPage(new PageCourtier(this));
            AddPage(new PageEngagement(this));
            AddPage(new InputPage(this));

            SetPage<MainPage>();
        }
    }
}
