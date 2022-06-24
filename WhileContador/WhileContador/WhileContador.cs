using System;

namespace WhileContador
{
    class WhileContador
    {
        static void Main(string[] args)
        {
            int contador = 1;       // inicialização
                                     
            while(contador <= 5)    // condição de repetição
            {
                Console.WriteLine(contador);
                contador++;        // incrementa
            } //fim do while
        } // fim do Main
    } // fim da classe WhileContador
}
