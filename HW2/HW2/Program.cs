using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = 0;
            int maxValue = 0;
            int tryCount = 3;
            string userData = null;
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.Title = "AVG";


            Console.WriteLine("************Средняя температура за сутки******************* \n\n");

            //Минимальная температура
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 1; i <= tryCount; i++)
            {
                Console.WriteLine("Введите минимальную температуру за сутки");
                userData = Console.ReadLine();
                if (!(Int32.TryParse(userData, out minValue)))
                {
                    if (i == tryCount)
                    {
                        Console.ForegroundColor = prevColor;
                        Console.WriteLine("Ну нет, так нет");
                        return;
                    } else
                        Console.WriteLine("Введите целое число");
                }
                else
                    break;
            }

            //Максимальная температура
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 1; i <= tryCount; i++)
            {
                Console.WriteLine("Введите максимальную температуру за сутки");
                userData = Console.ReadLine();
                if (!(Int32.TryParse(userData, out maxValue)))
                {
                    if (i == tryCount)
                    {
                        Console.ForegroundColor = prevColor;
                        Console.WriteLine("Ну нет, так нет");
                        return;
                    }else
                        Console.WriteLine("Введите целое число");
                }
                else
                    break;
            }

            Console.ForegroundColor = prevColor;
            Console.WriteLine($"Средняя температура: {(minValue + maxValue) / 2.00}");
            Console.Beep();
            Console.WriteLine("***********************************************************");



        }
    }
}
