como definir métodos com parâmetros e retorno;
como retornar algo usando a palavra chave return antes da expressão do resultado;
o uso do return para retornar antecipadamente a execução de um método;
como usar a referência this para acessar um atributo;
que podemos passar uma referência como parâmetro do método;
métodos são chamadas a partir da referência usando o operador ...


Realizar o relacionamento entre classes através de composição.
Vantagens de se isolar informações repetidas em outra classe.
Como namespaces funcionam no C#.
O que forma o nome completo de uma classe.
Como as diretivas using são usadas.
O valor null.


Há dois tipos em C#: tipos de referência e valor. Variáveis de tipos de referência armazenam referências em seus dados (objetos) enquanto que variáveis de tipos de valor contém diretamente seus dados.
...
As seguintes palavras-chaves são usadas para declarar tipos de referência:
class.
interface.
delegate.
gravável.

Visão geral das propriedades

Um acessador de propriedade get é usado para retornar o valor da propriedade e um acessador de propriedade set é usado para atribuir um novo valor. No C# 9 e posterior, um acessador de propriedade init é usado para atribuir um novo valor somente durante a construção do objeto

*****************************************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá " + nome + " bem-vindo ao C# Brasil!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}








