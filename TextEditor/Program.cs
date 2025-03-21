using System.Text;

namespace TextEditor {
    class Program {
        public static void Main(string[] args){
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");

            short option = short.Parse(Console.ReadLine()!);

            switch (option){
                case 0: Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string path = Console.ReadLine()!;

            using(var file = new StreamReader(path)){
                string text = file.ReadToEnd();

                Console.WriteLine(text);
            }

            Console.WriteLine("_______________");
            Console.ReadLine();
            Menu();
        }

        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("_________________________");

            var text = new StringBuilder();

            while (true) {
                var key = Console.ReadKey(intercept: true);

                if (key.Key == ConsoleKey.Escape)
                    break;

                if (key.Key == ConsoleKey.Enter) {
                    text.Append(Environment.NewLine);
                    Console.WriteLine();
                }
                else if (key.Key == ConsoleKey.Backspace && text.Length > 0) {
                    text.Remove(text.Length - 1, 1);
                    Console.Write("\b \b");
                }
                else {
                    text.Append(key.KeyChar);
                    Console.Write(key.KeyChar);
                }
            }

            Console.Clear();
            
            Salvar(text.ToString());
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine()!;

            using(var file = new StreamWriter(path)){
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Menu();
        }
    }
}
