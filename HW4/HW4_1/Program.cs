using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = ' ';

            Console.WriteLine("Введите числа через пробел");
            float sum = GetSum(Console.ReadLine().Split(delimiter));
            Console.WriteLine($"Сумма: {sum}");
            Console.ReadLine();
        }

        static float GetSum(string[] numbers)
        {
            float result = 0;

            foreach (string str in numbers)
            {
                if (float.TryParse(str, out float number))
                {
                    result += number;
                }
                else continue;
            }
            return result;
        }
    }
}
