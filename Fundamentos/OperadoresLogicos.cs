namespace CursoCsharp.Fundamentos
{
    public class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            System.Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            System.Console.WriteLine("Comprou o sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            System.Console.WriteLine("Comprou a TV 32?{0}", comprouTv32);

            System.Console.WriteLine("Mais saudável? {0}", !comprouSorvete);
        }
    }
}