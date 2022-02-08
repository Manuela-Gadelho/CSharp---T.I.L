A Biblioteca de Classes do .NET é uma coleção de milhares de classes que contém dezenas de milhares de métodos. Esses métodos são criados pela Microsoft e estão disponíveis para uso em seus aplicativos.

Uma classe é simplesmente um contêiner para métodos. Os desenvolvedores normalmente mantêm os métodos relacionados juntos em uma única classe. Por exemplo, os métodos que podem enviar ou receber informações de uma janela de linha de comando são coletados na classe System.Console na Biblioteca de Classes do .NET.

Em muitos casos, essas classes e métodos permitem que você crie um tipo específico de aplicativo. Por exemplo, um dos maiores subconjuntos de classes e métodos permite que você crie aplicativos Web dinâmicos. Há várias famílias de classes que permitem que você crie aplicativos de área de trabalho nativos. Outro subconjunto de classes e métodos permitem que você acesse um banco de dados.

Há outras classes com métodos que são mais de uso geral por natureza. Em outras palavras, seu utilitário abrange diferentes estruturas. Se desejar ler ou gravar em arquivos, executar operações de trigonometria ou cálculo e fazer chamadas para recuperar dados de toda a Internet, você poderá usar essas classes e métodos se estiver criando um aplicativo Web, de área de trabalho, móvel ou de nuvem.

Como você pode imaginar, ter uma grande biblioteca de funcionalidades disponível para seus aplicativos é uma enorme economia de tempo para você como desenvolvedor de software. E se você tivesse que começar do zero com cada novo aplicativo que desejasse criar?
**************************************************************************************

Métodos com estado vs. sem estado
Em computação, o estado descreve a condição do ambiente de execução em um momento específico no tempo. Conforme seu código executa linha por linha, os valores são armazenados em variáveis. A qualquer momento durante a execução, o estado atual do aplicativo é a coleção de todos os valores armazenados na memória.

Alguns métodos não dependem do estado atual do aplicativo para funcionarem corretamente. Em outras palavras, os métodos sem estado são implementados para que possam funcionar sem referenciar ou alterar os valores já armazenados na memória. Os métodos sem estado também são conhecidos como métodos estáticos.

Por exemplo, o método Console.WriteLine() não depende de nenhum valor armazenado na memória. Ele executa sua função e termina sem afetar o estado do aplicativo de qualquer forma.

Outros métodos, contudo, devem ter acesso ao estado do aplicativo para funcionar corretamente. Em outras palavras, os métodos com estado são criados de uma forma que dependem de valores armazenados na memória pelas linhas de código anteriores que já foram executadas. Ou eles modificam o estado do aplicativo atualizando valores ou armazenando novos valores na memória. Eles também são conhecidos como métodos de instância.

Os métodos com estado (instância) controlam seu estado em campos, que são variáveis definidas na classe. Cada nova instância da classe tem sua própria cópia desses campos nos quais o estado é armazenado.

Uma única classe pode dar suporte a métodos com e sem estado. No entanto, quando você precisa chamar métodos com estado, deve primeiro criar uma instância da classe para que o método possa acessar o estado.

******************************************************************************************
Criar uma instância de uma classe
Uma instância de uma classe é chamada de um objeto. Para criar uma instância de uma classe, use o operador new. Considere a seguinte linha de código que cria uma instância da classe Random para criar um objeto chamado dice:

C#

Copiar
Random dice = new Random();
O operador new faz várias coisas importantes:

Primeiro, ele solicita um endereço na memória do computador grande o suficiente para armazenar um novo objeto com base na classe Random.
Ele cria o objeto e o armazena no endereço de memória.
Ele retorna o endereço de memória para que ele possa ser salvo na variável dice.
Desse ponto em diante, quando a variável dice é referenciada, o Tempo de Execução do .NET executa uma pesquisa nos bastidores para dar a ilusão de que você está trabalhando diretamente com o próprio objeto.

***************************************
Recapitulação
Para chamar métodos de uma classe na Biblioteca de Classes do .NET, use o formato ClassName.MethodName(), em que o símbolo . é o operador de acesso de membro para acessar um método definido na classe e os símbolos () são os operadores de invocação de método.
Ao chamar um método sem estado, não é necessário criar uma instância de sua classe primeiro.
Ao chamar um método com estado, é necessário criar uma instância da classe e acessar o método no objeto.
Use o operador new para criar uma instância de uma classe.
Uma instância de uma classe é chamada de um objeto.


