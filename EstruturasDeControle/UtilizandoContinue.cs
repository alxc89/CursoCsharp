namespace CursoCsharp.EstruturasDeControle
{
    public class UtilizandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            System.Console.WriteLine($"Numeros pares entre 1 e {intervalo}!");

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                }

                System.Console.Write(i + " ");
            }
        }
    }
}