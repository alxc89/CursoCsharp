using System;
using System.Globalization;

namespace CursoCsharp.Fundamentos
{
    public class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            //Convertendo string em number/integer
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome} Idade: {idade}, Salário R${salario}");
        }
    }
}