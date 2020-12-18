using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneDirectory = new string[5, 2];

            for (int i = 0; i < phoneDirectory.GetLength(0); i++)
            {
                Console.WriteLine($"Введите имя {i+1}-го контакта");
                phoneDirectory[i, 0] = Console.ReadLine();

                Console.WriteLine($"Введите номер телефона или email");
                phoneDirectory[i, 1] = Console.ReadLine();

                Console.Clear();
            }

            for (int i = 0; i < phoneDirectory.GetLength(0); i++)
            {
                Console.WriteLine($"Имя: {phoneDirectory[i,0]} - {phoneDirectory[i, 1]}");
            }
        }
    }
}
