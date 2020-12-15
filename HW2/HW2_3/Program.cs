using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Четное число**************** \n\n");
            Console.WriteLine("Введите число");
            string userData = Console.ReadLine();

            if (Int32.TryParse(userData, out int number))
            {

                if (number % 2 == 0)
                    Console.WriteLine("Число четное");
                else
                    Console.WriteLine("Число нечетное");
            }
            else
                Console.WriteLine("Ну ты же знаешь, что нужно было cделать");
            Console.WriteLine("********************************************* \n\n");
        }
    }
}
