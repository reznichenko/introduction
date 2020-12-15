using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HW2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userData = null;
            int numberMonth = 0;
            int tryCount = 3;

            Console.WriteLine("***************Название месяца**************** \n\n");

            /* var1
            Console.WriteLine("Введите порядковый номер текущего месяца");
            userData = Console.ReadLine();
            Int32.TryParse(userData, out numberMonth);
            switch (numberMonth)
            {
                case 1:
                    Console.WriteLine("Январь");
                    break;
                case 2:
                    Console.WriteLine("Февраль");
                    break;
                case 3:
                    Console.WriteLine("Март");
                    break;
                case 4:
                    Console.WriteLine("Апрель");
                    break;
                case 5:
                    Console.WriteLine("Май");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль");
                    break;
                case 8:
                    Console.WriteLine("Август");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь");
                    break;
                case 10:
                    Console.WriteLine("Октябрь");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь");
                    break;
                case 12:
                    Console.WriteLine("Декабрь");
                    break;
                default:
                    Console.WriteLine("Укажите значение от 0 до 12");
                    break;

            }*/


            //var2
            for (int i = 1; i <= tryCount; i++)
            {
                Console.WriteLine("Введите порядковый номер текущего месяца");
                userData = Console.ReadLine();
                if (!(Int32.TryParse(userData, out numberMonth)) || numberMonth < 0 || numberMonth > 12)
                {
                    if (i == tryCount)
                    {
                        Console.WriteLine("Ну нет, так нет");
                        return;
                    }
                        Console.WriteLine("Введите целое число от 1 до 12");
                }
                else
                    break;

            }
            

            Console.WriteLine($"Текущий месяц : { CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(numberMonth)}");
            
            Console.WriteLine("*********************************************** \n\n");
        }
    }
}
