namespace CursoCsharp.EstruturasDeControle
{
    public class EstruturaIfElse
    {
        public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7.0)
            {
                System.Console.WriteLine("Aprovado!");
                System.Console.WriteLine("Não fez mais que sua obrigação...");
            }
            else
            {
                System.Console.WriteLine("Recuperação");
            }
        }
    }
}