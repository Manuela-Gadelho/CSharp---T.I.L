// caracteres e textos 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia";
            Console.WriteLine(titulo);

            Console.ReadLine();
        }
    }
}
**********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.ReadLine();
        }
    }
}
************************************************
// TRABALHANDO COM IF 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade. Pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos, mas está acompanhado. Pode entrar");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos, não pode entrar");
                }
            }

            Console.ReadLine();
        }
    }
}
*******************************************
MAIS SOBRE LAÇOS DE REPETIÇÃO 

-- WHILE -- 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorInvestido);

                contadorMes = contadorMes + 1;

            }
            Console.ReadLine();
        }
    }
}
************************************************************************
-- FOR -- 

static void Main(string[] args)
{
    Console.WriteLine("Executando o projeto 11");

    double valorInvestido = 1000;

    for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
    {
        valorInvestido *= 1.0036;
        Console.WriteLine(
            "Após " + contadorMes + 
            " meses, você terá R$" + valorInvestido);
    }
    Console.ReadLine();
}
************************************************************************

transformando while em for


-- codigo que usa while 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        int contador = 1;            
        while (contador <= 10)
        {
            Console.WriteLine(contador);
            contador++;
        }
    }
} 

-- transformado para for 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        for(int contador = 1; contador <= 10; contador++)
        {
            Console.WriteLine(contador);
        }
    }
}
