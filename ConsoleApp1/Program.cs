using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
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

            // MyNameSpace.Child.Test.Second();

            int[] numere = new int[] { 1, 8, 13, 21, 37, 41, 74, 12, 4, 3 };
            double[] preturi = new double[] { 13, 5, 1.5, 39, 100 };

            Console.WriteLine("--------------------");

            for (int index = 0; index < numere.Length; index++)
            {
                Console.WriteLine(numere[index]);
            };

            Console.WriteLine("Preturi reduse --------------------");

            for (int i = 0; i < preturi.Length; i++)
            {
                preturi[i] *= 0.9;
                Console.WriteLine(preturi[i]);

            }
            Console.WriteLine("--------------------");
            // numere.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            string[,] tabla = new string[3, 3] {
                {"0","0","x" },
                {"x","0","x" },
                {"0","x","0" }
            };

            if (tabla[0, 0] == tabla[1, 1] && tabla[1, 1] == tabla[2, 2])
            {
                Console.WriteLine("Castigatorul este: " + tabla[0, 0]);
            }
            for (int r = 0; r < tabla.GetLength(0); r++)
            {
                string row = "";
                for (int c = 0; c < tabla.GetLength(1); c++)
                {
                    row += " " + tabla[r, c];
                }
                Console.WriteLine(row);
            }

            //Sortare, cautare, comparare
            Console.WriteLine("--------------------");
            int[] nums = new int[] { 1, 9, 3, 5, 7, 6, 4, 2 };
            nums.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            Array.Sort(nums);
            Console.WriteLine("--------------------");
            nums.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            Console.WriteLine("--------------------");
            string[] names = new string[] { "Alex", "Ionut", "Dorin", "Bianca" };
            names.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Array.Sort(names);

            Console.WriteLine("cautare--------------------");
            int[] Numbers = new int[] { 1, 3, 5, 7, 9 };
            int five = Array.Find(Numbers, number => number == 5);
            int graterThan7 = Array.Find(Numbers, number => number > 7);
            Console.WriteLine(five + " " + graterThan7);

            Console.WriteLine("comparare--------------------");
            int[] Numbers2 = new int[] { 1, 3, 5, 7, 9 };
            Console.WriteLine(Numbers.SequenceEqual(Numbers2));

            Console.WriteLine("Opertatii utile ----------Take---------");
            double[] temperaturi = new double[10] { 13, 12, 10, 8, 9, 11, 19, 20, 15, 12 };
            double[] first2 = temperaturi.Take<double>(2).ToArray();
            first2.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Console.WriteLine("Average: " + temperaturi.Average());
            Console.WriteLine("Temp Max: " + temperaturi.Max());
            Console.WriteLine("Temp Min: " + temperaturi.Min());

            if (temperaturi.Contains(20))
            {
                Console.WriteLine("Contains " + 20);
            }

            if (temperaturi.Any(x => x==12))
            {
                Console.WriteLine("Exista o val egala cu 12");
            }

            double[] peste10 = temperaturi.Where(x => x > 10).ToArray();
            peste10.ToList().ForEach(i => Console.WriteLine(i.ToString()));

            int ct = temperaturi.Count(x => x > 10);
            Console.WriteLine( ct + " Nr de temp mai mari ca 10");

            Console.ReadKey();
            
        }
    }
}

