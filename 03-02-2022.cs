using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Lsitar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Delete!");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editar é muito bom");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada");
                    break;
                    
            }


            Console.WriteLine(opcaoSelecionada);
            Console.ReadLine();
        }
        enum Opcao { Criar = 1, Deletar, Editar, Listar, Atualizar }
    }
}
*****************************************************************
ESTRUTURAS DE REPETIÇÃO - WHILE 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador < 10)
            {
                Console.WriteLine("Rodando o while!");
                contador = contador + 1;
            }

            Console.WriteLine("Fim da linha!");
            Console.ReadLine();
                    
            }
        }
    }

