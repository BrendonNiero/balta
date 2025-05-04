using System;

namespace EditorHtml {
    public static class Draw {
        
        public static void Line(){
            Console.Write("+");
            for(int i = 0; i <=50; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }

        public static void Paragraph(){
            for(int lines = 0; lines <= 10; lines++) {
                Console.Write("|");
                for(int i = 0; i <= 50; i++)
                    Console.Write(" ");

                Console.Write("|");
                Console.Write("\n");
            }
        }
    }
}