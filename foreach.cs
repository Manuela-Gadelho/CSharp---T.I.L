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
            string[] palavras = { "Victor", "Lima", "Guia do programador", "Formação", "Node", "Curso de C#", "Udemy" };

            foreach (string palavra in palavras) // para cada palavra no array repita o bloco de codigo
            {
                Console.WriteLine("foreach rodando");
            }
            Console.ReadLine();
        }

    }
} 

 
