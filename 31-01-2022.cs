using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroQualquer = 20 + 20 - 80;
            int numeroMult = 10 * 90;
            int numeroDiv = 90 / 10;

            Console.WriteLine(numeroQualquer);
            Console.WriteLine(numeroMult);
            Console.WriteLine(numeroDiv);

            Console.ReadLine();

        }
    }
}


Estruturas Condicionais 

Estruturas condicionais são comuns e necessárias em todos os programas. A declaração if...else está entre as mais utilizadas pelos desenvolvedores. Este pequeno artigo aborda a sintaxe da declaração if...else e também explora outras construções condicionais presentes no C#. Algumas delas pouco conhecidas dos novos programadores e mais familiares para quem já utilizava a linguagem C.

Condicionais na prática 

else if - se o if for falso, não cai diretamente no else. condiciona todos os else if do codigo ate cair no else. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 2;

            if (250 >= 250) // SE

            {
                Console.WriteLine("É verdade!");
            }
            else if (a > c)
            {
                Console.WriteLine("Executou elseif! ");
                
            }
            else // SENÃO
            {
                Console.WriteLine("É mentira!");
            }



            Console.ReadLine();

        }
    }
}

Operadores lógicos 

formas de colocar duas condições dentro de uma condicional. 
https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/operators/boolean-logical-operators - referencia pra estudo 

Precedência do operador
A lista a seguir ordena os operadores lógicos, começando da mais alta precedência até a mais baixa:

Operador de negação lógica !
Operador AND lógico &
Operador OR exclusivo lógico ^
Operador OR lógico |
Operador AND lógico condicional &&
Operador OR lógico condicional ||

DOCUMENTAÇÃO DO C# 
https://docs.microsoft.com/pt-br/dotnet/csharp/

AND E OR NO C# 

AND - && 
OR - || 

