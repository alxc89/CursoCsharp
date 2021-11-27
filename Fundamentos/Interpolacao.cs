namespace CursoCsharp.Fundamentos
{
    public class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;
            //Concatenar com o +
            System.Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            //Concatenar com interpolação, primeira opção.
            System.Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            //Concatenar com interplação, segunda opção.
            System.Console.WriteLine($"A marca {marca} é legal!");
            System.Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");

            //Interpolação com soma
            System.Console.WriteLine($"1 + 1 = {1 + 1}! ");
        }
    }
}