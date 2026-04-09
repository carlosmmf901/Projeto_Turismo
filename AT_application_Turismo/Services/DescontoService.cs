namespace AT_application_Turismo.Services;

public class DescontoService
{
    private const decimal TAXA_DESCONTO = 0.10m;

    public decimal AplicarDesconto(decimal preco)
    {
        if (preco <= 0)
            return 0;

        return preco - (preco * TAXA_DESCONTO);
    }
}