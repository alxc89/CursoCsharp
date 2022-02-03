namespace CursoCsharp.EstruturasDeControle
{
    public class EstruturaSwitch
    {
        public static void Executar()
        {
            System.Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5");

            int.TryParse(System.Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    System.Console.WriteLine("Péssimo");
                    break;
                case 1:
                case 2:
                    System.Console.WriteLine("Ruim");
                    break;
                case 3:
                    System.Console.WriteLine("Regular");
                    break;
                case 4:
                    System.Console.WriteLine("Bom");
                    break;
                case 5:
                    System.Console.WriteLine("Ótimo");
                    break;
                default:
                    System.Console.WriteLine("Nota inválida");
                    break;
            }

            System.Console.WriteLine("Fim!");
        }
    }
}