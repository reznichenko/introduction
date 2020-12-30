using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Task Manager";
            pringProcess();
            Console.WriteLine("Введите ID жертвы");
            if(!int.TryParse(Console.ReadLine(), out int idProcess)){
                Console.WriteLine("Введите число.");
            }
            else
            {
                Process victim = Process.GetProcessById(idProcess);
                Console.WriteLine($"Убиваю {victim.ProcessName}");
                try
                {
                    victim.Kill();
                }
                catch(Win32Exception)
                {
                    Console.WriteLine("И кто тебе дал право?");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
            }

        }

        static void pringProcess() {
            Process[] prc = Process.GetProcesses();

            foreach (var item in prc)
            {
                Console.WriteLine($"ID = {item.Id} Name = {item.ProcessName}");
            }
            Console.WriteLine($"\nВсего процессов {prc.Length + 1}");
        }
    }
}
