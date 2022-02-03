namespace CursoCsharp.ClassesEMetodos
{
    public class ExemploEnum
    {
        public enum Genero
        {
            Acao, Aventura, Terror, Animacao, Comedia
        }

        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }

        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            System.Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknardo 17";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            System.Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}