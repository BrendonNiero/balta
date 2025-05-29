public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Cadastrar("");
        }
        catch (MinhaException ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.QuandoAconteceu}");
        }
        finally
        {
            Console.WriteLine("Chegou ao fim!");
        }
    }
    private static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new MinhaException(DateTime.Now);
        }
    }

    public class MinhaException : Exception
    {
        public MinhaException(DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu { get; set;  }
    }
}