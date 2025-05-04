using System;
using System.Security.Cryptography.X509Certificates;

namespace EditorHtml {
    public static class Menu {
        public static void Show() {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScren();
            WriteOptions();

            var options = short.Parse(Console.ReadLine()!);
            HandleMenuOption(options);
        }


        public static void DrawScren() {
            Draw.Line();
            Draw.Paragraph();
            Draw.Line();
        }

        public static void WriteOptions(){
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("----------------> Editor HTML <---------------");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir arquivo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option){
            switch(option){
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0: {
                    Console.Clear();
                    Environment.Exit(0);
                } break;
                default: Show(); break;
            }
        }
    }
}