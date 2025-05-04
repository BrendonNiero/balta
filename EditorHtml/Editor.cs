using System;
using System.Drawing;
using System.Text;


namespace EditorHtml {
    public static class Editor {
        public static void Show(){
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("________________");
            Start();
        }
        public static void Start(){
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.AppendLine(Environment.NewLine);
            } while(Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("__________________");
            Console.WriteLine("Deseja salvar o arquivo?");
            View.Show(file.ToString());
        }
    }
}