//Demonstrando operadores logicos

using System;

namespace OperadoresLogicosCS
{
    class Program
    {
        static void Main(string[] args)
        {
            //testando o operador E condicional (&&)
            Console.WriteLine("Condicional AND (&&)"+
                "\nfalse && false:" + (false && false)+
                "\nfalse && true:" + (false && true)+
                "\ntrue && false:" + (true && false)+
                "\ntrue && true:" + (true && true));

            //testando o operador OU condicional (||)
            Console.WriteLine("\n\nCondicional OR (||)"+
                "\nfalse || false:" + (false || false)+
                "\nfalse || true:" + (false || true)+
                "\ntrue || false:" + (true || false)+
                "\ntrue || true:" + (true || true));

            //testando o operador E logico (&)
            Console.WriteLine("\n\nLogico AND (&)"+
                "\nfalse & false:" + (false & false)+
                "\nfalse & true:" + (false & true)+
                "\ntrue & false:" + (true & false)+
                "\ntrue & true:" + (true & true));

            //testando o operador OU logico (|)
            Console.WriteLine("\n\nLogico OR (|)"+
                "\nfalse | false:" + (false | false)+
                "\nfalse | true:" + (false | true)+
                "\ntrue | false:" + (true | false)+
                "\ntrue | true:" + (true | true));

            //testando o operador OU exclusivo logico (^)
            Console.WriteLine("\n\nExclusivo Logico OR (^)" +
                "\nfalse ^ false:" + (false ^ false) +
                "\nfalse ^ true:" + (false ^ true) +
                "\ntrue ^ false:" + (true ^ false) +
                "\ntrue ^ true:" + (true ^ true));

            //testando o operador NAO logico (!)
            Console.WriteLine("\n\nExclusivo Logico OR (^)" +
                "\n!false:" + (!false)+
                "\n!true:" + (!true));
        }
    }
}
