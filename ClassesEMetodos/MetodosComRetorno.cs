namespace CursoCsharp.ClassesEMetodos
{
    public class MetodosComRetorno
    {
        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int a, int b)
            {
                return a - b;
            }

            public int Multiplicar(int a, int b)
            {
                return a * b;
            }
        }

        class CalculadoraCadeia
        {
            int memoria;
            public CalculadoraCadeia Somar(int a)
            {
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a)
            {
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar()
            {
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir()
            {
                System.Console.WriteLine(memoria);
                return this;
            }

            public int Resultado()
            {
                return memoria;
            }
        }
        public static void Executar()
        {
            var calculadoraComun = new CalculadoraComum();

            var resultado = calculadoraComun.Somar(5, 5);
            System.Console.WriteLine(resultado);
            System.Console.WriteLine(calculadoraComun.Subtrair(2, 7));
            System.Console.WriteLine(calculadoraComun.Multiplicar(4, 4));

            //Chamada encadeada;
            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(2).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(2).Multiplicar(3).Resultado();
            System.Console.WriteLine(resultado);
        }
    }
}