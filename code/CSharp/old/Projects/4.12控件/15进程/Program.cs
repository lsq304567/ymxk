using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15进程
{
    class Program
    {
        static void Main(string[] args)
        {
            ////获得当前程序中所有正在运行的进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    ////千万别试，关闭电脑所有进程
            //    //item.Kill();
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //通过进程打开一些应用程序
            //Process.Start("calc");//计算器
            //Process.Start("mspaint");//画图工具
            //Process.Start("notepad");//记事本

            //创建进程对象
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\PC\Desktop\001.txt");
            p.StartInfo = psi;
            p.Start();

            Console.ReadKey();

        }
    }
}
