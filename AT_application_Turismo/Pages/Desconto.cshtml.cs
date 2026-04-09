using AT_application_Turismo.Delegates;
using AT_application_Turismo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT_application_Turismo.Pages;

public class DescontoModel : PageModel
{
    [BindProperty]
    public decimal Preco { get; set; }

    public decimal? Resultado { get; set; }

    public void OnPost()
    {
        var service = new DescontoService();

        CalculateDelegate calcular = service.AplicarDesconto;

        Resultado = calcular(Preco);
    }
}