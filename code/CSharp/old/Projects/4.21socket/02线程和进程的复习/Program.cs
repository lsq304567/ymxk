using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02线程和进程的复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] pro= Process.GetProcesses();
            foreach (var item in pro)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //一个进程包含多个线程


        }
    }
}
