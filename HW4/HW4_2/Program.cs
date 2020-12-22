using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_2
{
    class Program
    {
        enum Seasons
        {   
            None,
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца");
            if (!int.TryParse(Console.ReadLine(), out int month) || month < 1 || month > 12)
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return;
            }

            Console.WriteLine(getRusSeason(getSeason(month)));
        }

        static Seasons getSeason(int numSeason)
        {
            switch (numSeason)
            {
                case 12:
                case 1:
                case 2:
                    return Seasons.Winter;
                case 3:
                case 4:
                case 5:
                    return Seasons.Spring;
                case 6:
                case 7:
                case 8:
                    return Seasons.Summer;
                case 9:
                case 10:
                case 11:
                    return Seasons.Autumn;
                default:
                    return Seasons.None;

            }
                
        }

        static string getRusSeason(Seasons season)
        {
            switch (season) {
                case Seasons.Winter:
                    return "Зима";
                case Seasons.Spring:
                    return "Весна";
                case Seasons.Summer:
                    return "Лето";
                case Seasons.Autumn:
                    return "Осень";
                default:
                    return "";
            }
        }

        
    }
}
