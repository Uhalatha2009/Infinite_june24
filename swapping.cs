using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swapping.prg
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, temp;
            Console.WriteLine("enter the first number:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore swapping:");
            Console.WriteLine("first number: " + n1);
            Console.WriteLine("second number: " + n2);

            temp = n1;
            n1 = n2;
            n2 = temp;

            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine("first number: " + n1);
            Console.WriteLine("second number: " + n2);

            Console.ReadLine();







        }
    }
}
