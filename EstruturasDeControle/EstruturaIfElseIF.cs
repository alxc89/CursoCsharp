namespace CursoCsharp.EstruturasDeControle
{
    public class EstruturaIfElseIF
    {
        public static void Executar()
        {
            System.Console.Write("Digite a nota do aluno: ");

            string entrada = System.Console.ReadLine();
            System.Double.TryParse(entrada, out double nota);

            if (nota >= 9)
            {
                System.Console.WriteLine("Quadro de honra!");
            }
            else if (nota >= 7)
            {
                System.Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5)
            {
                System.Console.WriteLine("Recuperação");
            }
            else
            {
                System.Console.WriteLine("Te vejo na próxima");
            }


        }
    }
}