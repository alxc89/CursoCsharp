namespace CursoCsharp.Fundamentos
{
    public class Inferencia
    {
        public static void Executar()
        {
            var nome = "Alex";
            // nome = 123 não é possível colocar um valor do tipo número, porque já ouve uma inferência de tipo nessa variável;
            System.Console.WriteLine(nome);

            // var idade; //Quando não coloca o tipo do dado na variável, é necessário inicializar a variável com um valor;
            var idade = 32; // forma correta de declarar variável sem inferir o tipo.
            System.Console.WriteLine(idade);

            int a;
            a = 3;
            int b = 2;

            System.Console.WriteLine(a + b);
        }
    }
}