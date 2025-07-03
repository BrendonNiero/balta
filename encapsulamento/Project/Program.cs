public class ContaBancaria
{
    private decimal saldo;

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

    public decimal ConsultarSaldo()
    {
        return saldo;
    }
}

// saldo está encapsulado
// -> não pode ser acessado diretamente de fora.