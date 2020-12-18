using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            char[] charArray = Console.ReadLine().ToArray();

            foreach (char c in charArray.Reverse())
            {
                Console.Write(c);
            }

            Console.WriteLine();

        }
    }
}
