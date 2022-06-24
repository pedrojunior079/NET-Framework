using System;

namespace Media1
{
    class Media1
    {
        static void Main(string[] args)
        {
            int total,  // soma das notas
                notaContador,  // numeron de notas fornecidas
                notaValor,      // valor da nota
                media;        // media de todas as notas

            // fase de inicialização
            total = 0;           // limpa o total
            notaContador = 1;    // prepara para o laço
                                  
            //fase de processamento
            while(notaContador <= 10) // repete o laço 10 vezes
            {
                // solicita a entrada e le a nota do usuario
                Console.Write("Entre integer nota:  ");

                //le a entrada e converte para inteiro
                notaValor = Int32.Parse(Console.ReadLine());

                // soma notaValor ao total
                total = total + notaValor;

                //soma 1 a notaContador
                notaContador = notaContador + 1;
            }

            //fase de conclusao

            media = total / 10; //divisao inteira

            //exibe a nedia das notas do exame
            Console.WriteLine("\nClasse media foi {0}", media);
        } // fim de nain
    } // fim da classe Media1
}
