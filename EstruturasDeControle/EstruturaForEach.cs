namespace CursoCsharp.EstruturasDeControle
{
    public class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                System.Console.WriteLine(letra);
            }

            var alunos = new string[] { "Alex", "Samira", "Joaquim" };

            foreach (var aluno in alunos)
            {
                System.Console.WriteLine(aluno);
            }
        }
    }
}