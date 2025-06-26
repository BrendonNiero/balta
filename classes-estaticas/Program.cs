namespace Program
{

    public class Program
    {
        public static void Main()
        {
            var resultadoSoma = Calcular.Somar(1, 5);
            Console.WriteLine(resultadoSoma);

            var dataVencimento = Boleto.DataVencimento();
            Console.WriteLine(dataVencimento);
        }
    }
    public static class Calcular
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public static double Dividir(double value, double d) { 
            return value / d;
        }
    }

}