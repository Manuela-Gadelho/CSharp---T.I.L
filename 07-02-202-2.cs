string message = null;

// warning: dereference null.
Console.WriteLine($"The length of the message is {message.Length}");

var originalMessage = message;
message = "Hello, World!";

// No warning. Analysis determined "message" is not null.
Console.WriteLine($"The length of the message is {message.Length}");

// warning!
Console.WriteLine(originalMessage.Length);

*******************************************************************

Você usa anotações que podem declarar se uma variável é um tipo de referência que pode ser anulada ou um tipo de referência não anulada. Essas anotações fazem instruções importantes sobre o estado nulo para variáveis:

Uma referência não deve ser nula. O estado padrão de uma variável de referência não anulada não é nulo. O compilador impõe regras que garantem que seja seguro desreferenciar essas variáveis sem primeiro verificar se ela não é nula:
A variável deve ser inicializada para um valor não nulo.
A variável nunca pode receber o valor null. O compilador emite um aviso quando o código atribui uma expressão talvez nula a uma variável que não deve ser nula.
Uma referência pode ser nula. O estado padrão de uma variável de referência que pode ser anulada é talvez nulo. O compilador impõe regras para garantir que você tenha verificado corretamente uma null referência:
A variável só poderá ser desreferenciada quando o compilador puder garantir que o valor não seja null .
Essas variáveis podem ser inicializadas com o valor null padrão e receber o valor null em outro código.
O compilador não emite avisos quando o código atribui uma expressão talvez nula a uma variável que pode ser nula.

*******************************************************************

O compilador emite avisos quando uma referência não anulada é atribuída a uma referência cujo estado é talvez nulo. Em geral, uma referência não anulada não é nula e nenhum aviso é emitido quando essas variáveis são desreferenciadas.

