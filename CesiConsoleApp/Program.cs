using System;

namespace CesiConsoleApp
{
    class Program
    {
        enum Saison
        {
            PRINTEMPS = 9,
            ETE = 5,
            AUTOMNE = 33,
            HIVER = 14

        }
        static void Main(string[] args)
        {
            int paramPasserParRef;
            MethodOut(out paramPasserParRef);
            Console.WriteLine(paramPasserParRef);
        }
        static void MethodOut(out int number) 
        {
            number = 42;
        }
    }
}
