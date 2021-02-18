using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha_Dinamica_Simplesmente_Encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Livro livro;
            Pilha_Dinamica_Livro minha_pilha = new Pilha_Dinamica_Livro { Topo = null };
            do
            {
                Console.WriteLine("\t1-Inserir Livro");
                Console.WriteLine("\n\t2-Remover Livro");
                Console.WriteLine("\n\t3-Imprimir Pilha");
                Console.WriteLine("\n\t4-Quantidade de Elementos na pilha");
                Console.WriteLine("\n\t5-Busca de Livro na Pilha por Título");
                Console.WriteLine("\n\t0-Sair");

                Console.Write("\nEscolha uma opção: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        livro = LerLivro();
                        minha_pilha.Push(livro);
                        string voltar = "";
                        Console.WriteLine("Deseja voltar ao menu inicial (digite s ou n): ");
                        voltar = Console.ReadLine();
                        if (voltar == "s") 
                        {
                            menu = 6;
                            Console.Clear();
                        }
                        break;
                    case 2:
                        minha_pilha.pop();
                        string voltar2 = "";
                        Console.WriteLine("Deseja voltar ao menu inicial (digite s ou n): ");
                        voltar2 = Console.ReadLine();
                        if (voltar2 == "s")
                        {
                            menu = 6;
                            Console.Clear();
                        }
                        break;
                    case 3:
                        minha_pilha.Imprimir();
                        string voltar3 = "";
                        Console.WriteLine("Deseja voltar ao menu inicial (digite s ou n): ");
                        voltar3 = Console.ReadLine();
                        if (voltar3 == "s")
                        {
                            menu = 6;
                            Console.Clear();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Quantidade de livros na pilha: " + minha_pilha.Quantidade());
                        string voltar4 = "";
                        Console.WriteLine("Deseja voltar ao menu inicial (digite s ou n): ");
                        voltar4 = Console.ReadLine();
                        if (voltar4 == "s")
                        {
                            menu = 6;
                            Console.Clear();
                        }
                        break;
                }
            } while (menu > 5);
            Console.ReadKey();
        }
        
        static public Livro LerLivro()
        {
            string titulo, aut;
            long isbn;
            do
            { 
                Console.Write("Informe o título do livro: ");
                titulo = Console.ReadLine();
            } while (titulo == "");

            do
            { 
                Console.Write("Informe o autor do livro: ");
                aut = Console.ReadLine();
            } while (aut == "");

            Console.Write("Informe o Isbn do livro: ");
            isbn = long.Parse(Console.ReadLine());

            Livro l = new Livro
            {
                Titulo = titulo,
                Autor = aut,
                Isbn = isbn,
            };
            return l;
        }
    }
}
