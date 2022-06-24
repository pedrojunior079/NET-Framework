using System;

// Pré-incremento e pós-incremento

namespace Incremento
{
    class Incremento
    {
        static void Main(string[] args)
        {
            int c;
            c = 5;
            Console.WriteLine(c);      // imprime 5
            Console.WriteLine(c++);    // imprime 5 e depois pos-incrementa
            Console.WriteLine(c);      // imprime 6

            Console.WriteLine();       // pula uma linha 

            c = 5;
            Console.WriteLine(c);      // imprime 5
            Console.WriteLine(++c);    // pré-incrementa e depois imprime 6
            Console.WriteLine(c);      // imprime 6
        } // fim do metodo Main
    } // fim da classe Incremento
}
