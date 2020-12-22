using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] poets = {{"Блог", "Есенин", "Маяковский"}, { "Александр", "Сергей", "Владимир"}, {"Александрович", "Александрович", "Владимирович"}};

            for (int i = 0; i < poets.GetLength(0); i++)
            {
                Console.WriteLine(GetFullName(poets[1, i], poets[0, i], poets[2, i]));
            }
            
        }

        static string GetFullName(string firstName, string lastName, string patronymic) {
            return $"ФИО: {lastName} {firstName} {patronymic} ";
        }
    }
}
