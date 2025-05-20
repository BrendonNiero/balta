using System.Globalization;

namespace Program
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            decimal salario = 2539.82m; // Quando trabalhamos com moeda

            Console.WriteLine(Math.Round(salario)); // Arredonda pra cima
            Console.WriteLine(Math.Floor(salario)); // Arredonda pra menos
        }
    }
}