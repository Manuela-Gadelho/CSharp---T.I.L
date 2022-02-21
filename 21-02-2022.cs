herança é um dos atributos fundamentais da poo. ela permite que você defina uma classe filha que reutiliza (herda), estende ou modifica o comportamento de uma classe pai. a classe cujos membros sçao herdados é chamada classe base e a classe que herda os membros da classe base é chamada de classe derivada.
c# e .net oferecem suporte somente a herança única, ou seja, uma classe pode herdar apenas de uma única classe.

Nem todos os membros de uma classe base são herdados por classes derivadas. Os membros a seguir não são herdados:

Construtores estáticos, que inicializam os dados estáticos de uma classe.

Construtores de instância, que você chama para criar uma nova instância da classe. Cada classe deve definir seus próprios construtores.

Finalizadores, que são chamados pelo coletor de lixo do runtime para destruir as instâncias de uma classe.

-----------------------------------------------------------------------------------

