using System;

namespace CursoCsharp.Fundamentos
{
    public class OperadoresAritimeticos
    {
        public static void Executar()
        {
            //Preço com desconto
            var preco = 1000.00;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto}");


            // Calculo do IMC

            double peso = 145;
            double altura = 1.80;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("IMC é {0}", imc);

            //Numero par/impar
            int par = 24;
            int impar = 55;

            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}