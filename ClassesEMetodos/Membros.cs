namespace CursoCsharp.ClassesEMetodos
{
    public class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Alex";
            sicrano.Idade = 32;

            // System.Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 32;

            var apresentacaoDoFulano = fulano.Apresentar();

            System.Console.WriteLine(apresentacaoDoFulano);
        }
    }
}