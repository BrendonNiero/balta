List<int> valores = new List<int> { 1, 2, 3 };


try
{
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine(valores[i]);
    }
} catch(ArgumentOutOfRangeException){
    Console.WriteLine("Indice não encontrado.");
}

