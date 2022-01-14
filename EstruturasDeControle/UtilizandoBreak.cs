using System;

namespace CursoCsharp.EstruturasDeControle
{
    public class UtilizandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            for (int i = 1; i <= 50; i++)
            {
                System.Console.Write($"O número que queremos é {numero}");
                if (i == numero)
                {
                    System.Console.WriteLine(" Sim!");
                    break;
                }
                else
                {
                    System.Console.WriteLine(" Não");
                }
            }
        }
    }
}