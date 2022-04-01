Construtores 

Sempre que uma classe ou struct é criada, o construtor é chamado. Uma classe ou struct pode ter vários construtores que usam argumentos diferentes. Os construtores permitem que o programador defina valores padrão, limite a instanciação e grave códigos flexíveis e fáceis de ler. Para obter mais informações e exemplos, consulte Construtores de instância eUsando construtores.

Um construtor é um método cujo nome é igual ao nome de seu tipo. Sua assinatura de método inclui apenas um modificador de acesso opcional, o nome do método e sua lista de parâmetros; ele não inclui um tipo de retorno. O exemplo a seguir mostra o construtor para uma classe denominada Person.

EXEMPLO:
public class Person
{
   private string last;
   private string first;

   public Person(string lastName, string firstName)
   {
      last = lastName;
      first = firstName;
   }

   // Remaining implementation of Person class.
}

