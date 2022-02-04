using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace CursoCsharp.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);//Adiciona na pilha

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");//Remove da pilha

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPeak: {pilha.Peek()}");//Não remove da pilha
            Console.WriteLine(pilha.Count);
        }
    }
}