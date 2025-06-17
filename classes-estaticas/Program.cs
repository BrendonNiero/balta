namespace Program
{

    public class Program
    { 
        public static void Main()
        {
            var resultadoSoma = Calcular.Somar(1, 5);
            Console.WriteLine(resultadoSoma);
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
    }
}