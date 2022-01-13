using System;
using System.Globalization;

namespace CursoCsharp.Fundamentos
{
    public class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            //Convertendo para string onde só tem uma casa decimal;
            Console.WriteLine(valor.ToString("F1"));
            //Convertendo para string onde o valor é currency/moeda;
            Console.WriteLine(valor.ToString("C"));
            //Convertendo para string onde será porcentual;
            Console.WriteLine(valor.ToString("P"));
            //Convertendo para string o número tem duas casas decimais;
            Console.WriteLine(valor.ToString("#.##"));

            //Formatando para uma cultura: Brasil;
            CultureInfo culturaBr = new CultureInfo("pt-BR");
            //Cultura Brasil sem nenhuma casa decimal
            Console.WriteLine(valor.ToString("C0", culturaBr));

            //Formatando para uma cultura: EUA;
            CultureInfo culturaEUA = new CultureInfo("en-US");
            //Cultura EUA três casas decimais;
            Console.WriteLine(valor.ToString("C3", culturaEUA));

            //Colocando zeros a direita, onde o D10 mostra a quantidade de caracteres o atributo vai ter;
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }

    }
}