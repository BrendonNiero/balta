using System.Globalization;

namespace Program
{
    public class Program()
    {
        public static void Main(string[] args)
        {
            decimal salario = 2500.22m; // Quando trabalhamos com moeda
            Console.WriteLine(salario.ToString(
            "C",
            CultureInfo.CreateSpecificCulture("pt-BR"))); // Converte para valor BR
        }
    }
}