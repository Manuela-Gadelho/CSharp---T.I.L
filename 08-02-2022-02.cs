using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            bool something = a + b > 10;
            if (something)
                Console.WriteLine("The answer is great");


        }
    }
}

******************************************************

Usar bibliotecas e estruturas de aplicativos do .NET para aproveitar a funcionalidade pré-criada
Todos os softwares são criados em camadas, o que significa que são executados em vários níveis de abstração em um computador:

No nível mais baixo, o software se comunica diretamente com o hardware do computador. Ele controla o fluxo de dados na placa-mãe, nos processadores, na memória e nos discos rígidos.
No nível seguinte, o software permite que o usuário final forneça instruções por meio de um sistema operacional.
No próximo nível, um software como o .NET fornece uma maneira para você desenvolver e executar aplicativos.
No nível seguinte, as estruturas de aplicativo e as bibliotecas de funcionalidade permitem criar rapidamente aplicativos avançados usando menos esforço do que os métodos de desenvolvimento mais antigos permitiam.
Uma biblioteca de códigos encapsula a funcionalidade para uma finalidade específica em um assembly. Para o .NET, milhares de bibliotecas estão disponíveis. Essas bibliotecas podem ser próprias ou de terceiros e podem ser comerciais ou de software livre. Elas fornecem uma ampla gama de funcionalidades que você pode usar em seus aplicativos. Basta fazer referência a esses assemblies e chamar os métodos necessários. Dessa forma, como desenvolvedor, você cria com base no trabalho de outros desenvolvedores de software. Você poupa tempo e energia porque não precisa criar e manter todos os recursos por conta própria.

Uma estrutura do aplicativo combina várias bibliotecas relacionadas, bem como projetos iniciais, modelos de arquivos, geradores de código e outras ferramentas. Use esses recursos a fim de criar aplicativos inteiros para uma finalidade específica. Essas estruturas de aplicativos são conhecidas como modelos de aplicativo. Por exemplo, estruturas de aplicativos do .NET populares estão disponíveis para modelos de aplicativos como desenvolvimento para a Web e desenvolvimento móvel, de área de trabalho e de jogos.

Você pode instalar o SDK do .NET diretamente ou instalando o Visual Studio 2022. O SDK do .NET instala um conjunto abrangente de bibliotecas e estruturas de aplicativos chamado biblioteca de classes base. Você pode usar essa biblioteca de código em seus programas, independentemente da plataforma ou dos modelos de aplicativos que deseja compilar.

Para outras bibliotecas de terceiros, os desenvolvedores usam gerenciadores de pacotes como o NuGet para localizar e integrar bibliotecas de código de repositórios de pacotes, como a Galeria do NuGet.
  
*Como valor é uma variável do tipo por valor (é um int), o seu valor padrão é 0, logo é not null.* 

A maneira mais eficiente de comparar se duas strings são iguais é usar o método Equals. 
  
*************************************************************************

O runtime do .NET é como uma bolha protetora que fornece um ambiente de execução para seus aplicativos. O runtime do .NET:

Compila o código intermediário em um formato binário na primeira vez que o programa é executado. O formato binário é específico para a plataforma e a arquitetura (por exemplo, Windows de 64 bits) no computador em que ele está sendo executado.
Localiza o ponto de entrada do programa e começa a executar cada instrução na sequência apropriada.
Gerencia os recursos do computador, como memória e acesso à rede. Quando você ouve que o runtime do .NET "gerencia memória", isso significa que ele funciona com o sistema operacional para provisionar memória para seu aplicativo. Quando o aplicativo não precisar mais dos dados armazenados na memória, um recurso de coleta de lixo liberará essa memória de volta para o sistema operacional sem nenhuma instrução do desenvolvedor de software.
Protege o computador do usuário de softwares potencialmente mal-intencionados. Ele também fornece uma camada de isolamento entre aplicativos.
