using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;


namespace HW5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "ToDo.json";
            List<ToDo> doings = Load(filename);
            char[] delimeters = { ' ', '#' };

            Console.WriteLine("Введите список задач через пробел или номера выполненных задач");

            string[] tasks = Console.ReadLine().Split(delimeters);

            foreach (string task in tasks)
            {
                if (Int32.TryParse(task, out int num) && num-1 >= 0 && num-1 < doings.Count)
                    doings[num-1].IsDone = !doings[num - 1].IsDone;
                else if(task.Length> 0)
                   doings.Add(new ToDo(task));
            }

            Save(filename, doings);
            
            Console.ReadLine();
        }

        static void Save(string filename, List<ToDo> doings)
        {
            print(doings);
            string json = JsonSerializer.Serialize(doings);
            File.WriteAllText(filename, json);
        }

        static List<ToDo> Load(string filename) {
            List<ToDo> doings;

            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                doings = JsonSerializer.Deserialize<List<ToDo>>(json);
                print(doings);
            }
            else
                doings = new List<ToDo>(3);

            return doings;
        }
        static void print (List<ToDo> lst)
        {
            for (int i = 0; i < lst.Count; i++)
            {
                string finished = lst[i].IsDone ? "[x]" : "   ";
                Console.WriteLine($"#{i + 1} {finished}{lst[i].Title}");
            }
        }
    }
}
