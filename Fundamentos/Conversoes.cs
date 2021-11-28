using System;

namespace CursoCsharp.Fundamentos
{
    public class Conversoes
    {
        public static void Executar()
        {
            //Não há perigo de perda de informação. Não é preciso fazer implicito, porque o double armazena o valor int por ser de tamanho maior;
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Retorna erro, porque não possível converter um double em inteiro implicitamente;
            double nota = 9.7;
            //Forma implicita retorna erro;
            //int notaTruncada = nota;
            //Forma explicita retorna sem erro;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada: {0}", notaTruncada);
            Console.WriteLine($"Nota truncada: {notaTruncada}");
            //Convertendo string para inteiro;
            //Tomar cuidado com esse tipo de conversão, porque se o input for um texto ex: alexcardoso. Isso irá retornar erro;
            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");
            //Outra forma de converter string em número utilizando o Convert, que fica disponivel dentro de System;
            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            //Forma mais segura de converter string em número é utilizando o tryParse;
            Console.Write("Digite o primeiro número: ");
            string palavra = Console.ReadLine();
            int numero1;
            //o tryParse recebe dois parâmetros, o primeiro é o valor que será convertido, e o segundo onde será armazenado;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"Primeiro resultado: {numero1}");

            //Forma otimazada
            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Segundo resultado: {numero2}");
        }
    }
}