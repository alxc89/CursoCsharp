namespace CursoCsharp.Fundamentos
{
    public class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 5; // num1 = num1 * 5;
            num1 /= 2; // num1 = num1 / 2;

            System.Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // operador unário de incremento;
            b--; // operador unário de decremento;

            System.Console.WriteLine($"{a} {b}");

            // atribuição por referência.
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";
            //vai imprimir Maria. Porque c.nome e d.nome ocupam o mesmo espaço em memória;
            System.Console.WriteLine(c.nome);
        }
    }
}