public class Aluno
{
    private double Nota;

    public void DefinirNota(double nota)
    {
        if (nota >= 0 && nota <= 10)
            Nota += nota;
        else
            Console.WriteLine("Insira um valor de 0 a 10.");
    }

    public double ObterNota()
    {
        return Nota;
    }
}