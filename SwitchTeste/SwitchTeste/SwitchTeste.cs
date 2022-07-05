using System;

namespace SwitchTeste
{
    class SwitchTeste
    {
        static void Main(string[] args)
        {
            char nota;              // uma nota
            int aContador = 0,     // número de notas A
                bContador = 0,     // número de notas B
                cContador = 0,     // número de notas C
                dContador = 0,     // núnero de notas D
                fContador = 0;     // número de notas F

            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Entre com a letra da nota: ");
                nota = Char.Parse(Console.ReadLine());

                switch(nota)
                {
                    case 'A':     // a nota é A maiusculo
                    case 'a':     // ou a minúsculo
                        ++aContador;
                        break;

                    case 'B':    // a nota é B maiúsculo
                    case 'b':    // a nota é b minúsculo
                        ++bContador;
                        break;

                    case 'C':    // a nota é C maiúsculo
                    case 'c':    // a nota é c minúsculo
                        ++cContador;
                        break;

                    case 'D':    // a nota é D maiúsculo
                    case 'd':    // a nota é d minúsculo
                        ++dContador;
                        break;

                    case 'F':    // a nota é F maiúsculo
                    case 'f':    // a nota é f minúsculo
                        ++fContador;
                        break;

                    default:     // processa todos os outros caracteres
                        Console.WriteLine("Nota de letra incorreta inserida" +
                                          "\nNota não adicionada aos totais.");
                        break;
                } // fim do switch
            } // fim do for

            Console.WriteLine("\nOs totais para cada nota de letra são: \nA: {0}" +
                              "\nB: {1}\nC: {2}\nD: {3}\nF: {4}", aContador, bContador,
                              cContador, dContador, fContador);
        } // fim do metodo main
    } // fim da classe Switchteste
}
