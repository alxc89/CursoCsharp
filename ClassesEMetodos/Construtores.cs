namespace CursoCsharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        //Criando o construtor padrão, já que o construtor acima é um construtor personalizado;
        public Carro() { }
    }
    public class Construtores
    {
        public static void Executar()
        {
            //Construtor padrão;
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            System.Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");

            //Construtor personalizado;
            var carro2 = new Carro("Ka", "Ford", 2018);
            System.Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            //Outra forma de utilizar o construtor padrão;
            var carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2019
            };
            System.Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");
        }
    }
}