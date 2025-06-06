class Program
{
    static void Main()
    {
        Cliente c1 = new Cliente(1, "Brendon Berzins", "brendonberzins@gmail.com");
        Cliente c2 = new Cliente(2, "Ana Jhonson", "anajulia@gmail.com");

        c1.ExibirDados();
        c2.ExibirDados();
    }
}