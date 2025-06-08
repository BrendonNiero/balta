public class Program
{
    static void Main()
    {
        List<int> Valores = [1, 2, 3, 4, 5, 6];
        Console.WriteLine(SomarTudo(Valores));

        Console.WriteLine(HoraAtual());

    }

    public static int SomarTudo(List<int> numeros)
    {
        return numeros.Sum();
    }

    public static string HoraAtual()
    {
        DateTime hora = DateTime.Now;
        return hora.ToString("D");
    }
}