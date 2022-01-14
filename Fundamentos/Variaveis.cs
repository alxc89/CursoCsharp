namespace CursoCsharp.Fundamentos
{
    public class Variaveis
    {
        public static void Executar()
        {
            //area circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;

            System.Console.WriteLine(area);
            System.Console.WriteLine("Área é " + area);

            //Tipos internos

            bool estaChovendo = true;
            System.Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 32;
            System.Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            System.Console.WriteLine("Saldo de gols: " + saldoDeGols);

            short salario = short.MaxValue;
            System.Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros!
            System.Console.WriteLine("Menor int: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000; //Interiro somente valores positivos 
            System.Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            System.Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000; //Long somente valores positivos
            System.Console.WriteLine("População mundial: " + populacaoMundial);

            float precoComputador = 1299.99f; //f no final é para sinalizar que é float.
            System.Console.WriteLine("Preço computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais utilizado dos reais!
            System.Console.WriteLine("Valor Apple" + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            System.Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            System.Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de c#";
            System.Console.WriteLine(texto);
        }
    }
}