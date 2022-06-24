using System;

// Usando instruções if, operadores relacionais e operadores de igualdade

namespace Comparacao
{
    class Comparacao
    {
        static void Main(string[] args)
        {
            int numero1, // primeiro número a comparar
                numero2; // segundo numero a comparar

            // le o primeiro numero do usuario
            Console.Write("Por favor entre com primeiro inteiro: ");
            numero1 = Int32.Parse(Console.ReadLine());

            // le o segundo numero do usuario
            Console.Write("\nPor favor entre com o segundo inteiro: ");
            numero2 = Int32.Parse(Console.ReadLine());

            if (numero1 == numero2)
                Console.WriteLine(numero1 + " == " + numero2);

            if (numero1 != numero2)
                Console.WriteLine(numero1 + " != " + numero2);

            if (numero1 < numero2)
                Console.WriteLine(numero1 + " < " + numero2);

            if (numero1 > numero2)
                Console.WriteLine(numero1 + " > " + numero2);

            if (numero1 <= numero2)
                Console.WriteLine(numero1 + " <= " + numero2);

            if (numero1 >= numero2)
                Console.WriteLine(numero1 + " >= " + numero2);
        
        } // fim do mtetodo main
    } // fim da classe Comparacao
}
