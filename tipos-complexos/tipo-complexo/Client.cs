class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataCadastro { get; private set; }

    public Cliente(int id, string nome, string email)
    {
        Id = id;
        Nome = nome;
        Email = email;
        DataCadastro = DateTime.Now;
    }

    public void ExibirDados()
    {
        Console.WriteLine("----------- CLIENTE ------------");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Cadastrado em: {DataCadastro}");
        Console.WriteLine("---------------------------------");
    }
}