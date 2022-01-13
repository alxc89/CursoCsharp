using System;

namespace CursoCsharp.ClassesEMetodos
{
    public class Readonly
    {
        public class Cliente
        {
            public string Nome;

            // utilizando o readonly, esse valor será setado no construtor e depois não será mais alterado.
            readonly DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataNascimento()
            {
                return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
        }
        public static void Executar()
        {
            var novoCliente = new Cliente("Alex", new DateTime(1989, 10, 11));
            System.Console.WriteLine(novoCliente.Nome);
            System.Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}