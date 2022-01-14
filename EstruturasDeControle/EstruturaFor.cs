namespace CursoCsharp.EstruturasDeControle
{
    public class EstruturaFor
    {
        public static void Executar()
        {
            for (int i = 1; i <= 10; i++)
            {
                System.Console.WriteLine($"O valor de i é {i}");
            }

            double somatorio = 0;
            string entrada;

            System.Console.Write("Informe o tamanho da turma: ");
            entrada = System.Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                System.Console.Write($"Informe a nota do aluno {i}: ");
                entrada = System.Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            System.Console.WriteLine($"Media da turma: {media}");
        }
    }
}