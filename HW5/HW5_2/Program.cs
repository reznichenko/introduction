using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userData;
            char[] separators = new char[] { ' ', '.', ':', ';', ',' };
            byte[] forRecord;
            int index = 0;
            bool existsErrors = false;
            string filename = "bytes.bin";

            Console.WriteLine("Введите набор чисел (0...255)");
            userData = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);
            forRecord = new byte [userData.Length];

            for (int i = 0; i < userData.Length; i++)
            {
                if (byte.TryParse(userData[i], out byte value))
                {
                    forRecord[index] = value;
                    index++;
                }
                else
                    existsErrors = true;
            }
            File.WriteAllBytes(filename, forRecord);

            if(existsErrors)
                Console.WriteLine("Ошибочные значения были исключены из набора");

            Console.WriteLine("Запись завершена");
        }
    }
}
