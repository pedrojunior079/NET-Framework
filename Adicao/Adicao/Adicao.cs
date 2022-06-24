using System;

//Fig. 3.11: Adicao.cs
//um programa de soma


namespace Adicao
{
    class Adicao
    {
        static void Main(string[] args)
        {
            string primeiroNumero, //primeira string fornecida pelo usuario
                   segundoNumero; // segunda string fornecida pelo usuario

            int numero1,  // primeiro numero a somar
                numero2, // segundo numero a somar
                soma;    // soma de numero1 e numero2

            // solicita e le o primeiro numero do usuario como string
            Console.Write("pro favor entre com primeiro inteiro: ");
            primeiroNumero = Console.ReadLine();

            // le o segundo numero do usuario como string
            Console.Write("\nPor favor entre com segundo inteiro: ");
            segundoNumero = Console.ReadLine();

            // converte numeros de tipo string para tipo int
            numero1 = Int32.Parse(primeiroNumero);
            numero2 = Int32.Parse(segundoNumero);

            // soma os numeros
            soma = numero1 + numero2;

            // exibe o resultado
            Console.WriteLine("\nA soma foi {0}.", soma);
        } // fim do metodo Main
    } // fim da classe Adicao
}
