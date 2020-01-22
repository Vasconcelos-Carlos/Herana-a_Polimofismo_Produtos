using System;
using System.Collections.Generic;
using ExercicioPordutos.Entities;

namespace ExercicioPordutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> ListaProduto = new List<Produto>();

            Console.Write("Quantos produtos seram registrados: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n;i++) 
            {
                Console.WriteLine($"Produto #{i}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine());

                Console.Write("(Comum = c / Usado = u / Importado = i) ");
                char tipo = char.Parse(Console.ReadLine());
                if(tipo == 'c' || tipo == 'C')
                {
                    ListaProduto.Add(new Produto(nome, preco));

                }
                else if (tipo == 'u' || tipo == 'U')
                {
                    Console.Write("Data de fabricação ( DD/MM/YYYY ): ");
                    DateTime fabricaçao = DateTime.Parse(Console.ReadLine());

                    ListaProduto.Add(new ProdutoUsado(nome, preco, fabricaçao));

                }

                else if(tipo == 'i' || tipo == 'I')
                {
                    Console.Write("Taxa alfandegaria: ");
                    double taxa = double.Parse(Console.ReadLine());

                    ListaProduto.Add(new ProdutoImportado(nome, preco, taxa));

                }

                Console.WriteLine();

            }
            Console.WriteLine("-=-=-=-=-=--=-=-==-=-==-=--=");
            Console.WriteLine("Etiqueta de Preços");
            foreach(Produto produto in ListaProduto)
            {
                Console.WriteLine(produto.TagPrice());
            }
            Console.WriteLine("-=-=-=-=-=--=-=-==-=-==-=--=");

        }
    }
}
