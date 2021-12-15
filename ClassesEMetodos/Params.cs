namespace CursoCsharp.ClassesEMetodos
{
    public class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                System.Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("Alex", "Samira", "Joaquim");
        }
    }
}