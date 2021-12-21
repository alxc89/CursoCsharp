namespace CursoCsharp.ClassesEMetodos
{
    public class AtributosEstaticos
    {

        public class Produto
        {
            public string Nome;
            public double Preco;

            //Atributo de classe e não de instância;
            public static double Desconto = 0.1;

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
            }

            public Produto() { }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }
        public static void Executar()
        {
            // var produto1 = new Produto("Caneta", 3.2);
            // var produto2 = new Produto("Borracha", 5.3);
            Produto.Desconto = 0.5;

            // System.Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            // System.Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());

        }
    }
}