namespace Stopwatch {
    public class Program{
        public static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine()!.ToLower();
            // Substring serve para pegar um deternimado caractere em uma string
            char type = char.Parse(data.Substring(data.Length -1, 1));
            Console.WriteLine(type);
        }

        static void Start(int time){
            int currentTime = 0;
            while(currentTime != time){
                currentTime ++;
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
        }
    }
}