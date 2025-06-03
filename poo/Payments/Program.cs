using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            PagamentoBoleto pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.vencimento = DateTime.Now;
            pagamentoBoleto.num_boleto = 534255423;

            Console.WriteLine("Seu pagamento vence em :", pagamentoBoleto.vencimento);
            pagamentoBoleto.Pagar();
        }
    }

    class Pagamento
    {
        public DateTime vencimento;
        public void Pagar() { }
    }

    class PagamentoBoleto : Pagamento
    {
        public int num_boleto;
    }
}