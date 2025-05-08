using System;
using System.Globalization;

public class Program {
    public static void Main(string[] args){
        var data = DateTime.Now;
        
        // Formatando data

        //Pegando ano
        var yearDate = String.Format("{0:yyyy}", data);

        //Mês e dia escrito
        var monthAndDay = String.Format("{0:M}", data);

        //Ano e Mês
        var monthAndYear = String.Format("{0:Y}", data);

        // Dia Mês Ano

        var formated = String.Format("{0:dd-MM-yyyy}", data);

        // Horário curto 00:00
        string shortCurrentHour = String.Format("{0:t}", data);

        // Data curta dd/mm/yyyy
        string shortCurrentDate = String.Format("{0:d}", data);

        // Horário Longo 14:54:00
        string longCurrentHour = String.Format("{0:T}", data);

        // Data Longa terça-feira, 6 de maio de 2025
        string longCurrentDate = String.Format("{0:D}", data);

        // Data e Hora longa Juntos terça-feira, 6 de maio de 2025 14:58
        string longCurrentDateTime = String.Format("{0:f}", data);

        // 2025-05-06T15:01:47
        string longDateFormated = String.Format("{0:s}", data);

        Console.WriteLine(longDateFormated);

        // Comparações

        var currentDateTime = DateTime.Now;

        if(currentDateTime == DateTime.Now){
            Console.WriteLine("É igual!"); // O bloco nunca vai ser executado pois ele compara mili segundos
        }


        //CultureInfo

        var pt = new CultureInfo("pt-BR");
    }
}