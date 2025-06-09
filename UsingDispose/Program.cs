public class Recurso : IDisposable
{
    public void Usar()
    {
        Console.WriteLine("Usando o recurso...");
    }

    public void Dispose()
    {
        Console.WriteLine("Liberando o recurso...");
    }
}
