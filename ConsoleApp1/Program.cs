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

            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);

            Console.ReadKey();

            
        }
    }
}

namespace MyNameSpace
{
    namespace Child
    {
        class Test { }
    }
}