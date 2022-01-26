Um tipo que é definido como um class é um tipo de referência. Em tempo de execução, quando você declara uma variável de um tipo de referência, a variável contém o valor null até que você crie explicitamente uma instância da classe usando o new operador ou atribua a ela um objeto de um tipo compatível que pode ter sido criado em outro lugar, conforme mostrado no exemplo a seguir:

//Declaring an object of type MyClass.
MyClass mc = new MyClass();

//Declaring another object of the same type, assigning it the value of the first object.
MyClass mc2 = mc;

Quando o objeto é criado, memória suficiente é alocada no heap gerenciado para o objeto específico, e a variável contém apenas uma referência para o local do objeto. Os tipos no heap gerenciado requerem sobrecarga quando são alocados e quando são recuperados pela funcionalidade de gerenciamento automático de memória do CLR, que é conhecida como coleta de lixo. No entanto, a coleta de lixo também é altamente otimizada e, na maioria dos cenários, não cria um problema de desempenho. Para obter mais informações sobre a coleta de lixo, consulte Gerenciamento automático de memória e coleta de lixo.

A palavra-chave class é precedida pelo nível de acesso. Como public é usado neste caso, qualquer pessoa pode criar instâncias dessa classe. O nome da classe segue a palavra-chave class. O nome da classe deve ser um nome do identificador válido em C#. O restante da definição é o corpo da classe, em que o comportamento e os dados são definidos. Campos, propriedades, métodos e eventos em uma classe são coletivamente denominados de membros de classe.


** IMPORTANTE ** https://docs.microsoft.com/pt-br/dotnet/csharp/fundamentals/types/classes ** IMPORTANTE ** 

Quando uma classe declara uma classe base, ela herda todos os membros da classe base, exceto os construtores.

Os tipos de estrutura têm semântica de valor. Ou seja, uma variável de um tipo de estrutura contém uma instância do tipo . Por padrão, os valores de variáveis são copiados na atribuição, passando um argumento para um método e retornando um resultado de método. No caso de uma variável de tipo de estrutura, uma instância do tipo é copiada. Para obter mais informações, confira Tipos de valor.

using System;

public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        Name = "unknown";
    }

    // Constructor that takes one argument:
    public Person(string name)
    {
        Name = name;
    }

    // Auto-implemented readonly property:
    public string Name { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name;
    }
}
class TestPerson
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        var person1 = new Person();
        Console.WriteLine(person1.Name);

        // Call the constructor that has one parameter.
        var person2 = new Person("Sarah Jones");
        Console.WriteLine(person2.Name);
        // Get the string representation of the person2 instance.
        Console.WriteLine(person2);
    }
}
// Output:
// unknown
// Sarah Jones
// Sarah Jones


