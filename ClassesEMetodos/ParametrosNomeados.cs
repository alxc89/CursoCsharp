namespace CursoCsharp.ClassesEMetodos
{
    public class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            //o D2 fica com a quantidade de caracteres;
            System.Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    }
}