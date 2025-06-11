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

    public static void Main()
    {
        Recurso recurso = new Recurso();

        try
        {
            recurso.Usar();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            recurso.Dispose();
        }
    }
}

