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
        var logService = new LogService();

        CalculateDelegate calcular = service.AplicarDesconto;

        Resultado = calcular(Preco);
        
        Action<string> logger = logService.LogToConsole;
        logger += logService.LogToFile;
        logger += logService.LogToMemory;

        logger($"Desconto aplicado no valor {Preco}");
    }
    
    
    
}