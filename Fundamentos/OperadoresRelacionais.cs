namespace CursoCsharp.Fundamentos
{
    public class OperadoresRelacionais
    {
        public static void Executar()
        {
            // double nota = 6.0;
            System.Console.Write("Digite a nota: ");
            double.TryParse(System.Console.ReadLine(), out double nota);
            double notadeCorte = 7.0;

            System.Console.WriteLine("Nota inválida? {0},", nota > 10.0);
            System.Console.WriteLine("Nota inválida? {0},", nota < 0);
            System.Console.WriteLine("Perfeito? {0},", nota == 10.0);
            System.Console.WriteLine("Tem com melhorar? {0},", nota != 10.0);
            System.Console.WriteLine("Passou por média? {0},", nota >= notadeCorte);
            System.Console.WriteLine("Recuperação? {0},", nota < notadeCorte);
            System.Console.WriteLine("Reprovado? {0},", nota <= 3.0);
        }
    }
}