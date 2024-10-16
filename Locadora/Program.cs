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

            Console.Write("Quantos produtos deseja adicionar? ");
            int qtd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < qtd; i++)
            {
                int opcao = 0;
                while (true)
                {

                    Console.WriteLine("Filme ou Série?");
                    Console.WriteLine("1 - Filme");
                    Console.WriteLine("2 - Série");

                    Console.WriteLine();
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (opcao == 1 || opcao == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção Inválida. Tente novamente.");
                    }
                }

                if (opcao == 1)
                {

                    Console.Write("Nome do Filme: ");
                    string nome = Console.ReadLine();
                    Console.Write("Gênero do Filme: ");
                    string genero = Console.ReadLine();
                    Console.Write("Valor do Filme: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    catalog.Add(new Filme(nome, genero, valor));
                    Console.WriteLine();

                }
                else if (opcao == 2)
                {

                    Console.Write("Nome da Série: ");
                    string nome = Console.ReadLine();
                    Console.Write("Gênero da Série: ");
                    string genero = Console.ReadLine();
                    Console.Write("Valor da Série: ");
                    double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    catalog.Add(new Serie(nome, genero, valor));
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }

                Console.WriteLine();
            }
            foreach (Locadora obj in catalog)
            {
                Console.WriteLine(obj.ToString());
            }
        }
    }
}