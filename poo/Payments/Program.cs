﻿using System;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo Orientação a objetos com balta!");
        }
    }

    class Pagamento
    {
        DateTime venciment;

        void Pagar()
        {
            ConsultarSaldo("884848484");
        }

        private void ConsultarSaldo(string numeroCartao) { }
    }
}