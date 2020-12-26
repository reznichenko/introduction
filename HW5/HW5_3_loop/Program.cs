using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW5_3_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите каталок");
            string path = Console.ReadLine();
            string filename = "DirTree.txt";
            string sub = "|_";

            if (File.Exists(filename))
                File.Delete(filename);

            string[] dirs;
            dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

            for (int i = 0; i < dirs.Length; i++)
            {
                if(i > 0 && dirs[i-1]==Convert.ToString(Directory.GetParent(dirs[i])))
                   sub = " " + sub;
                fixResult(filename, $"{sub}Dir:  {dirs[i]}");
                
                string[] files = Directory.GetFiles(dirs[i]);
                foreach (var file in files)
                {
                    fixResult(filename, $" {sub}FIle: {Path.GetFileName(file)}"); ;
                }
            }
        }

        static void fixResult(string filename, string str)
        {

            Console.WriteLine(str);
            File.AppendAllText(filename, $"{str}\n");
        }
    }
}
