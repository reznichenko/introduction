using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите каталок");
            string path = Console.ReadLine();
            string filename = "DirTree.txt";

            if (File.Exists(filename))
                File.Delete(filename);

            dir(path, filename);
        }

        static void fixResult(string filename, string str) {

            Console.WriteLine(str);
            File.AppendAllText(filename, $"{str}\n");
        }

        static void dir(string path, string filename, string sub = "|_") {

            sub = " " + sub;

            fixResult(filename, $"{sub}Dir:  {path}");

            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                fixResult(filename, $" {sub}FIle: {Path.GetFileName(file)}"); ;
            }

            string [] directories = Directory.GetDirectories(path);

            foreach (var directory in directories)
            {
                dir(directory, filename, sub);
            }
        }
    }
}
