namespace CursoCsharp.Fundamentos
{
    public class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 7;
            bool bomComportamento = false;
            string resultado = nota >= 7 && bomComportamento
                ? "Aprovado" : "Reprovado";

            System.Console.WriteLine(resultado);
        }
    }
}