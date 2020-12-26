using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "text.txt";

            Console.WriteLine("Введите текст для записи");
            File.WriteAllText(filename, Console.ReadLine());
        }
    }
}
