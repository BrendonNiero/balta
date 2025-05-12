public class Program {
    public static void Main(string[] args){

        var diasDoMesFevereiro = DateTime.DaysInMonth(2025, 2);
        Console.WriteLine(diasDoMesFevereiro);
    }

    // Função para saber se é fim de semana
    public bool IsWeekend(DayOfWeek today){
        return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
}