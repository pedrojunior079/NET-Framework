using System;

// Analise dos resultados do exame

namespace Analises
{
    class Analises
    {
        static void Main(string[] args)
        {
            int aprovados = 0,        // numero de aprovações
                reprovados = 0,       // numero de reprovações
                alunos = 1,           // contador de alunos
                resultado;            // resultado de um exame

            // processo 10 alunos; laços controlados por contador
            while(alunos <= 10)
            {
                Console.WriteLine("Entre com resultado (1=aprovado, 2=reprovado): ");
                resultado = Int32.Parse(Console.ReadLine());

                if (resultado == 1)
                    aprovados = aprovados + 1;
                else
                    reprovados = reprovados + 1;
                alunos = alunos + 1;
            }
            
            // fase de conclusão
            Console.WriteLine();
            Console.WriteLine("Aprovado: " + aprovados);
            Console.WriteLine("Reprovado: " + reprovados);

            if (aprovados > 8)
                Console.WriteLine("Aumentar Mensalidade\n");
        } // fim dp método Main
    } // fim da classe Analises
}
