namespace CursoCsharp.ClassesEMetodos
{
    public class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }

        public class CPonto
        {
            public int X;
            public int Y;
        }

        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Atribuição por valor!!
            ponto1.X = 3;

            System.Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            System.Console.WriteLine("Cópia Ponto 1 X: {0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; //Atribuição por referência!!
            ponto2.X = 4;

            System.Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            System.Console.WriteLine("Cópia Ponto 2 X: {0}", copiaPonto2.X);

        }

    }
}