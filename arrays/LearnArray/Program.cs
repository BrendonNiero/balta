using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Percorrendo um array: ");
        List<int> Numeros = new List<int> { 323, 5445, 6, 7, 76 };

        foreach (int value in Numeros)
        {
            Console.WriteLine(value);
        }
    }
}