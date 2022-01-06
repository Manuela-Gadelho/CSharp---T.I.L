//Veja as afirmações abaixo sobre a compilação e execução de código C#:

1 - Durante a compilação acontece uma verificação sintática do código fonte.

2 - Na compilação e execução podem aparecer erros.

3 - Quando executamos o programa compilado, a CLR lê e executa o código MSIL gerado.

4 - O compilador gera o MSIL caso não tenha nenhum erro sintático no código fonte.//

************************************************************************************

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
            Console.WriteLine("Olá, mundo! Este é meu primeiro programa");
        }
    }
}



*************************************************************************************
Um IDE é um ambiente integrado de desenvolvimento que centraliza em um único lugar: compilador da linguagem utilizada, editor de texto, documentação, banco de dados e tudo que gira em torno da criação de aplicações.

O Visual Studio Community é a versão gratuita da IDE Visual Studio.

*******************************************
CRIANDO VARIÁVEIS 

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
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine(idade);

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}


***************************************
CRIANDO VARIÁVEIS DOUBLE

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
            Console.WriteLine("Executando projeto  3 Criando variáveis ponto flutuante");

            double salario;
            salario = 1220.70;

            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;

            Console.WriteLine(idade);

            idade = 5 / 3;
            Console.WriteLine(idade);

            Console.WriteLine("A execução acabou. Tecle entender para sair...");
            Console.ReadLine();
        }
    }
}
************************************************
OUTROS TIPOS NUMÉRICOS 

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
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;

            //O int é um tipo de variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // O long é uma variável de 64 bits
            long idade = 130000000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variável de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();

        }
    }
}
Foi possível entender um pouco de type casting, e como podemos passar um valor de um tipo para uma variável de outro. Para alguns casos nós não precisamos fazer nada, pois o casting é implícito. Em outros, precisamos deixar claro para o compilador que sabemos o que estamos fazendo, mostrando entre parênteses o tipo que queremos que seja usado.
