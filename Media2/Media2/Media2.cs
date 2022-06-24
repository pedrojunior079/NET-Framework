using System;

namespace Media2
{
    class Media2
    {
        static void Main(string[] args)
        {
            int total,          // soma das notas
                notaContador,   // numero de notas fornecidas
                notaValor;      // valor da nota

            double media;       // media de todas as notas

            // fase de inicialização
            total = 0;          // limpa total
            notaContador = 0;   // prepara para o laço

            // fase de processamento
            // solicita entrada e converte para inteiro
            Console.Write("Entre nota inteiro, - 1 para Sair: ");
            notaValor = Int32.Parse(Console.ReadLine());

            // repete o laço até que -1 seja fornecido pelo usuario
            while(notaValor != -1)
            {
                // soma notaValor ao total
                total = total + notaValor;

                // soma 1 a notaContador
                notaContador = notaContador + 1;

                // solicita entrada e le a nota do usuario
                // converte a nota de string para inteiro
                Console.Write("Entre nota inteiro, -1 para Sair: ");
                notaValor = Int32.Parse(Console.ReadLine());
            } // fim do while

            // fase de conclusão 
            if(notaContador != 0)
            {
                media = (double) total / notaContador;

                // exibe a média das notas do teste
                Console.WriteLine("\nClasse media é {0}", media);
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi inserida.");
            }
        } // fim do metodo Main
    } // fim da classe Media2
}
