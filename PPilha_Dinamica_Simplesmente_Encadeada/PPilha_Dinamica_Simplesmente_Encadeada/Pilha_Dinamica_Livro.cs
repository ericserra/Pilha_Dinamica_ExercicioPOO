using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha_Dinamica_Simplesmente_Encadeada
{
    class Pilha_Dinamica_Livro
    {
        public Livro Topo { get; set; }

        public void Push(Livro aux)
        {
                aux.Anterior = Topo;
                Topo = aux;
            Console.WriteLine("Elemento inserido com sucesso!");
            return;
        }

        private bool Vazia()
        {
            if (Topo == null)
                return true;
            else
            return false;
        }

        public void Imprimir()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Imprimir! Pilha Vazia!");
            }
            else
            {
                Livro aux = Topo;
                Console.WriteLine("Os elementos na pilha são:");
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Anterior;
                } while (aux != null);
                Console.WriteLine(">>>FIM<<");
            }
        }

        public void pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Remover! Pilha Vazia!");
                Console.ReadKey();
            }
            else
            {
                Topo = Topo.Anterior;
                Console.WriteLine("Elemento Removido!");
            }
        }

        public int Quantidade()
        {
            int cont = 0;
            if (Topo != null)
            {
                Livro aux = Topo;
                do
                {
                    cont++;
                    aux = aux.Anterior;

                } while (aux != null);
            }
            return cont;
        }
    }
}
