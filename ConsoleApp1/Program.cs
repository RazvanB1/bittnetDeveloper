using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!!!!");
            Console.WriteLine("My first branch message");

            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            MyNameSpace.Child.Test.Second();

            Console.ReadKey();

            
        }
    }
}

namespace MyNameSpace
{
    namespace Child
    {
        class Test
        {
           internal static void Second( )
            {
                Console.WriteLine("Hello World!!!!!! Second");
                Console.WriteLine("My first branch message - Second");

                int[] numere = new int[] { 1, 8, 13, 21, 37, 41 };
                Console.WriteLine(numere.Length);
                Console.WriteLine(numere.Rank);

                Console.ReadKey();
            }
        }
    }
}