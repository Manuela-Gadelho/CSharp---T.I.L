using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Manu();
            
        }
        static void Manu()
        {
            Console.WriteLine("Estou usando funções");
            Console.WriteLine("Bem-vindo!");
        }

    }
    
}
 ************************************************************
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            // testando array's
            
            string[] cor ;
             cor = new string[5];

            cor[1] = "azul";
            cor[2] = "amarelo";
            cor[3] = "vermelho";
            cor[4] = "rosa";
            cor[5] = "verde";

            switch (cor) {
                case "azul":
                    Console.WriteLine("sua cor favorita é azul");
                    break;
                case "amarelo":
                    Console.WriteLine("sua cor favorita é amarelo");
                    break;
                case "vermelho":
                    Console.WriteLine("sua cor favorita é vermelho");
                    break;
                case "rosa":
                    Console.WriteLine("sua cor favorita é rosa");
                    break;
                case "verde":
                    Console.WriteLine("sua cor favorita é verde");
                    break;
                    
                          }
            Console.ReadLine();
        }
     
    }
}
