using EasyConsole;

namespace HelloEasyConsole.Pages.Commerce.GroupeCourtier
{
    class PageGroupeCourtier : MenuPage
    {
        public PageGroupeCourtier(Program program)
            : base("Groupe de courtier", program,
                    new Option("Lister les groupes de courtier", () => program.NavigateTo<PageListerGroupeCourtier>()),
                    new Option("Consulter un groupe de courtier", () => program.NavigateTo<PageConsulterGroupeCourtier>()),
                    new Option("Créer un groupe de courtier", () => program.NavigateTo<PageCreerGroupeCourtier>()),
                    new Option("Modifier un groupe de courtier", () => program.NavigateTo<PageModifierGroupeCourtier>()),
                    new Option("Supprimer un groupe de courtier", () => program.NavigateTo<PageSupprimerGroupeCourtier>()))
        {
        }
    }
}
