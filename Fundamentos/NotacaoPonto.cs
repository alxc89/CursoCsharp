namespace CursoCsharp.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar()
        {
            //Notação ponto abre os métodos do tipo, no exemplo de string, o ponto abre esses métodos abaixo;
            var saudacao = "olá".ToUpper()
                                .Insert(3, " World!")
                                .Replace("World!", "Mundo!");

            System.Console.WriteLine(saudacao);

            //Tomar cuidado com a notação ponto em atributos vazios;
            //Exemplo retornará erro, porque não é possível ler o tamanho de um atributo null;
            string valorImportante = null;
            //System.Console.WriteLine(valorImportante.Length);

            //Quando não se tem certeza se vai retornar null ou não, coloque ? no fim.

            System.Console.WriteLine(valorImportante?.Length);

        }
    }
}