namespace CursoCsharp.Fundamentos
{
    public class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            System.Console.WriteLine(-valorNegativo);
            System.Console.WriteLine(!booleano);
            numero1++; //operador pós fixado;
            System.Console.WriteLine(numero1);
            --numero1; //operador pré fixado; 
            System.Console.WriteLine(numero1);

            //Vai retornar True, porque quando se utiliza o operador pós fixado ele não vai ser resolvido tão rápido;
            //E o operador pré fixado vai ser resolvido o quanto antes, e antes do pós fixado.
            System.Console.WriteLine(numero1++ == --numero2);
        }
    }
}