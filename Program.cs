using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._19_lesson_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number:");
            int b = Int32.Parse(Console.ReadLine());

            if (a > b) { Console.WriteLine(a); }
            else { Console.WriteLine(b); }



        }
    }
}
