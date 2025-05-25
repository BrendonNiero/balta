using System;

class Program
{
    public static void Main(string[] args)
    {
        List<int> meuArray = new List<int> { 11, 23, 03 };
        List<string> frutas = new List<string> { "Mexirica", "Caqui", "Kiwi", "Pitaya" };

        Console.WriteLine(string.Join(" | ", meuArray));
        Console.WriteLine(string.Join(" | ", frutas));
    }
}