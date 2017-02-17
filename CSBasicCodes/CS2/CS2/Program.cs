using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Please Enter a Number");
            i = int.Parse(Console.ReadLine());
            if(i % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
            Console.ReadLine();
        }
    }
}
