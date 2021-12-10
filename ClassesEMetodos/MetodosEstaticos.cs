namespace CursoCsharp.ClassesEMetodos
{
    public class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            //Métodos estáticos podem se acessado através da classe;
            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

            //Métodos não estaticos só é acessível através de uma instância;
            public int Somar(int a, int b)
            {
                return a + b;
            }
        }
        public static void Executar()
        {
            //Acessando o método estático através da classe;
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            System.Console.WriteLine($"Resultado: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            System.Console.WriteLine(calc.Somar(2, 2));
        }
    }
}