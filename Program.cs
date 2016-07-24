using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact;
            int x = 1;
            Console.WriteLine("Please enter your number to be factored:");
            fact = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= fact; i++)
            {
                x = x * i ;

            }
            Console.WriteLine("your Factorial =");
            Console.WriteLine(x);
            Console.ReadKey();
        }

    }
}
