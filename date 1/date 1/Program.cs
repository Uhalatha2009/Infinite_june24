﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name:");
            string name = Console.ReadLine();

            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"your name is {name} and you are {age} years old.");

            Console.ReadKey();
        }
    }
}



