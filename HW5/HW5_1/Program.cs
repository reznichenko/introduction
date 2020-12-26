using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string point = DateTime.Now.ToString() + "\n";
            string filename = "startup.txt";
            File.AppendAllText(filename, point);
            Console.WriteLine(point);
        }
    }
}
