namespace CursoCsharp.ClassesEMetodos
{
    public class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            //Acessar a variável 'a' dentro do método Executar!

            DesafioAtributo desafioAtributo = new DesafioAtributo();
            System.Console.WriteLine(desafioAtributo.a);
        }
    }
}