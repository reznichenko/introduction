using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("До какого значения вычислять?");
            if (int.TryParse(Console.ReadLine(), out int num)) 
                Console.WriteLine(getFeb(num));
            else
                Console.WriteLine("Ошибка ввода");
        }
        
        static int getFeb(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else if (number == 0)
                return 0;
            else
                return getFeb(number - 2) + getFeb(number - 1);
        }
        
    }
}
