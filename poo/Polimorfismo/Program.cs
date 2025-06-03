class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late: Au Au!");
    }
}

class Gato : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O gato mia: Miau!");
    }
}

class Program
{
    static void Main()
    {
        Animal meuAnimal = new Animal();
        Animal meuCachorro = new Cachorro();
        Animal meuGato = new Gato();

        meuAnimal.FazerSom();
        meuCachorro.FazerSom();
        meuGato.FazerSom();
    }
}