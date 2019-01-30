using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13电脑_移动硬盘_U盘_mp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现，将移动硬盘或者硬盘或mp3插到电脑上进行读写设计
            MobileStorage ms = new UDisk();
            Computer cpu = new Computer
            {
                Ms = ms
            };
            //ms.Read();
            //ms.Write();
            string str = null;
            if (string.IsNullOrEmpty(str))
            {
                
            }

            //Computer cpu = new Computer();
            cpu.CpuRead();
            cpu.CpuWrite();
            Console.ReadKey();



        }
    }
}
