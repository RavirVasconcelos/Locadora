using System;
using System.Globalization;
using System.Collections.Generic;

namespace Locadora
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Locadora> catalog = new List<Locadora>();
            bool continuar = true;

            while(continuar)
            {
                Console.WriteLine("--------- BEM-VINDO A LOCADORA ---------");
                Console.WriteLine("Filme ou Série?");
                Console.WriteLine("1 - Filme");
                Console.WriteLine("2 - Série");
                Console.WriteLine("3 - Livro");

                int opcao;
                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao != 1 && opcao != 2 && opcao != 3))
                {
                    Console.WriteLine("Opção inválida, tente denovo");
                }

                Console.Clear();

                if (opcao == 1)
                {
                    Console.Write("Quantos filmes deseja adicionar: ");

                    int qtd;
                    while (!int.TryParse(Console.ReadLine(), out qtd) || (qtd <= 0))
                    {
                        Console.WriteLine("Quantidade inválida, tente denovo");
                    }

                    for (int i = 1; i <= qtd; i++)
                    {
                        Console.Write("Nome do Filme: ");
                        string nome = Console.ReadLine();
                        Console.Write("Gênero do Filme: ");
                        string genero = Console.ReadLine();
                        Console.Write("Valor do Filme: ");
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("ID do Filme: ");
                        int id = int.Parse(Console.ReadLine());

                        catalog.Add(new Filme(nome, genero, valor, id));
                        Console.WriteLine();

                        Console.Clear();
                    }
                }
                else if (opcao == 2)
                {
                    Console.Write("Quantos series deseja adicionar: ");

                    int qtd;
                    while (!int.TryParse(Console.ReadLine(), out qtd) || (qtd <= 0))
                    {
                        Console.WriteLine("Quantidade inválida, tente denovo");
                    }

                    for (int i = 1; i <= qtd; i++)
                    {
                        Console.Write("Nome da Serie: ");
                        string nome = Console.ReadLine();
                        Console.Write("Gênero do Serie: ");
                        string genero = Console.ReadLine();
                        Console.Write("Valor da Serie: ");
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("ID da Serie: ");
                        int id = int.Parse(Console.ReadLine());

                        catalog.Add(new Serie(nome, genero, valor, id));
                        Console.WriteLine();

                        Console.Clear();
                    }
                }
                else if (opcao == 3)
                {
                    Console.Write("Quantos livros deseja adicionar: ");

                    int qtd;
                    while (!int.TryParse(Console.ReadLine(), out qtd) || (qtd <= 0))
                    {
                        Console.WriteLine("Quantidade inválida, tente denovo");
                    }
                    for (int i = 1; i <= qtd; i++)
                    {
                        Console.Write("Nome do Livro: ");
                        string nome = Console.ReadLine();
                        Console.Write("Gênero do Livro: ");
                        string genero = Console.ReadLine();
                        Console.Write("Valor do Livro: ");
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("ID do Livro: ");
                        int id = int.Parse(Console.ReadLine());

                        catalog.Add(new Livro(nome, genero, valor, id));
                        Console.WriteLine();

                        Console.Clear();
                    }
                }

                Console.WriteLine("Deseja continuar adicionando? (s/n)");
                continuar = Console.ReadLine().ToLower() == "s";

                Console.Clear();
            }
            
            Console.Write("Digite o ID para pesquisar o produto: ");
            int searchId = int.Parse(Console.ReadLine());

            foreach (var id in catalog)
            {
                Console.WriteLine(id);
            }
            foreach (Locadora obj in catalog)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}