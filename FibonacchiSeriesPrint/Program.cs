using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacchi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c;
            Console.Write("Enter a Number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i < number; i++)
            {
                c = a + b;
                Console.WriteLine(c);

                a = b;
                b = c;


            }
            Console.ReadLine();


        }
    }
}
