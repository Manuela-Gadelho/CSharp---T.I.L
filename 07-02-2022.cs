Os construtores são tipos especiais de métodos usados ​​para criar e inicializar objetos. ... Dessa forma se você não definir nenhum construtor para a classe, o C# vai criar um construtor padrão que instancia o objeto e define valores padrão para os membros da classe.



É o bloco de construção básico da programação orientada a objetos e é reutilizável. Uma classe C# define propriedades, campos, eventos, métodos, etc. Um objeto é uma instância de uma classe. Modificadores de acesso definem a acessibilidade de uma classe: public, private, protected ou internal.14 de dez. de 2017

Na programação de computadores, uma cadeia de caracteres ou string é uma sequência de caracteres, geralmente utilizada para representar palavras, frases ou textos de um programa. ... Nas linguagens formais, uma cadeia de caracteres é uma sequência finita de símbolos escolhidos a partir de conjunto denominado alfabeto.


Strings são cadeias de caracteres que armazenam dados textuais e, portanto, podem armazenar informações para as mais diversas finalidades. O conteúdo de uma string pode representar um fato em si, ou uma informação.


Um método estático indica que na verdade não sabe a quem pertence, como ele não é um método de instância, ele não precisa da instância da classe para ser usado, então, a rigor, ele fica meio à vontade usando a assinatura da classe e não usa o estado interno da classe.

leitura importante: https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members 

Uma classe estática pode ser usada como um contêiner conveniente para conjuntos de métodos que operam apenas em parâmetros de entrada e não precisam obter ou definir campos de instância internos. Por exemplo, na Biblioteca de Classes do .NET, a classe estática contém métodos que executam operações matemáticas, sem nenhum requisito para armazenar ou recuperar dados exclusivos de uma instância específica da System.Math Math classe. Ou seja, você aplica os membros da classe especificando o nome de classe e o nome do método. 

double dub = -3.14;  
Console.WriteLine(Math.Abs(dub));  
Console.WriteLine(Math.Floor(dub));  
Console.WriteLine(Math.Round(Math.Abs(dub)));  
  
// Output:  
// 3.14  
// -4  
// 3


A lista a seguir fornece os principais recursos de uma classe estática:

- Contém apenas membros estáticos.

- Não pode ser instanciada.

- É lacrada.

- Não pode conter Construtores de instância.

Classes estáticas são lacradas e, portanto, não podem ser herdadas. Elas não podem herdar de qualquer classe, exceto por Object. Classes estáticas não podem conter um construtor de instância. No entanto, eles podem conter um construtor estático. Classes não estáticas também devem definir um construtor estático se a classe contiver membros estáticos que exigem inicialização não trivial. Para obter mais informações, consulte Construtores estáticos.

Exemplo: 
public static class TemperatureConverter
{
    public static double CelsiusToFahrenheit(string temperatureCelsius)
    {
        // Convert argument to double for calculations.
        double celsius = Double.Parse(temperatureCelsius);

        // Convert Celsius to Fahrenheit.
        double fahrenheit = (celsius * 9 / 5) + 32;

        return fahrenheit;
    }

    public static double FahrenheitToCelsius(string temperatureFahrenheit)
    {
        // Convert argument to double for calculations.
        double fahrenheit = Double.Parse(temperatureFahrenheit);

        // Convert Fahrenheit to Celsius.
        double celsius = (fahrenheit - 32) * 5 / 9;

        return celsius;
    }
}

class TestTemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Please select the convertor direction");
        Console.WriteLine("1. From Celsius to Fahrenheit.");
        Console.WriteLine("2. From Fahrenheit to Celsius.");
        Console.Write(":");

        string selection = Console.ReadLine();
        double F, C = 0;

        switch (selection)
        {
            case "1":
                Console.Write("Please enter the Celsius temperature: ");
                F = TemperatureConverter.CelsiusToFahrenheit(Console.ReadLine());
                Console.WriteLine("Temperature in Fahrenheit: {0:F2}", F);
                break;

            case "2":
                Console.Write("Please enter the Fahrenheit temperature: ");
                C = TemperatureConverter.FahrenheitToCelsius(Console.ReadLine());
                Console.WriteLine("Temperature in Celsius: {0:F2}", C);
                break;

            default:
                Console.WriteLine("Please select a convertor.");
                break;
        }

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
/* Example Output:
    Please select the convertor direction
    1. From Celsius to Fahrenheit.
    2. From Fahrenheit to Celsius.
    :2
    Please enter the Fahrenheit temperature: 20
    Temperature in Celsius: -6.67
    Press any key to exit.
 */
 
 ************************************************************
 
 public List<string> GetPropertyValue(string propertyName,
                                     StringSearchOption StringSearchOption = StringSearchOption.StartsWith,
                                     bool trimSpaces = true)
{
    StreamReader sr = null;
    List<string> results = new List<string>();
    string line = "";
    string testLine = "";

    try
    {
        sr = new StreamReader(p_filePath);

        while (!sr.EndOfStream)
        {
            line = sr.ReadLine();

            // Perform a case-insensitive search by using the specified search options.
            testLine = line.ToUpper();
            if (trimSpaces) { testLine = testLine.Trim(); }

            switch (StringSearchOption)
            {
                case StringSearchOption.StartsWith:
                    if (testLine.StartsWith(propertyName.ToUpper())) { results.Add(line); }
                    break;
                case StringSearchOption.Contains:
                    if (testLine.Contains(propertyName.ToUpper())) { results.Add(line); }
                    break;
                case StringSearchOption.EndsWith:
                    if (testLine.EndsWith(propertyName.ToUpper())) { results.Add(line); }
                    break;
            }
        }
    }
    catch
    {
        // Trap any exception that occurs in reading the file and return null.
        results = null;
    }
    finally
    {
        if (sr != null) {sr.Close();}
    }

    return results;
}

****************************************************
 
