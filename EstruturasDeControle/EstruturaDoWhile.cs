namespace CursoCsharp.EstruturasDeControle
{
    public class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;

            do
            {
                System.Console.WriteLine("Qual seu nome?");
                entrada = System.Console.ReadLine();

                System.Console.WriteLine($"Seja bem vindo {entrada}");
                System.Console.WriteLine("Deseja continuar? (S/N)");
                entrada = System.Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}