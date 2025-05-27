public class Program
{
    public static void Main(string[] args)
    {
        Cadastrar("");
    }
    private static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
        {
            throw new ArgumentNullException("O valor é nulo e não pode ser exibido.");
        }
    }
}