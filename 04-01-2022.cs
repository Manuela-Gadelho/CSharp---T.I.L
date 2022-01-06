Como usar o break no C#?
Quando o comando BREAK é utilizado ele interrompe o laço assim que a condição desejada é atendida, fazendo o programa efetuar a leitura da próxima linha após o laço.

escrevendo asteriscos com o break 

static void Main(string[] args)
{
    Console.WriteLine("Projeto 13");

    // *
    // **
    // ***
    // ****
    // *****
    // ******
    // *******
    // ********
    // *********
    // **********

    // Escrevendo asterisco com o BREAK
        for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
    {
        for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
        {
            Console.Write("*");
            if(contadorColuna >= contadorLinha)
                break;
        }
        Console.WriteLine();
    }

    // Uma forma diferente de fazer o desenho de asteríscos
    for(int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
    {
        for(int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.ReadLine();
}

**********************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(String[] args)
        {
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if ( coluna > linha )
                    {
                        break;
                    }
                    Console.Write( coluna+1 );
                }
                Console.WriteLine();
            }
        }
    }
} 

**********************************************
tabuada 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(String[] args)
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
    }

***********************************************
fatorial 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(String [] args)
        {
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        }
    }
}


*************************************************

- A sintaxe do while e for;
- O operador +=;
- O operador ++;
- Laços aninhados;
- A funcionalidade do break.

