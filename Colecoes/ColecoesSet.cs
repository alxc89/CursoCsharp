using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CursoCsharp.Colecoes.ColecoesList;

namespace CursoCsharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.99),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3); 

            foreach(var item in carrinho)
            {
                //Console.WriteLine(carrinho.IndexOf(item)); Não tem como Pegar o index, porque o HasSet não é uma estrutura indexada
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro); //Exemplo para mostrar que o HashSet não aceita duplificação de itens.
            Console.WriteLine(carrinho.Count); 
            //Console.WriteLine(carrinho.LastIndexOf(livro)); Não tem como pegar o ultimo index, porque o HasSet não é uma estrutura indexada
        }
    }
}
