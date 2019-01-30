using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"G:\html项目\002css3入门\css\老赵.wav";
            //获得文件名
            Console.WriteLine(Path.GetFileName(str));
            //获得文件名但不包含扩展名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获得扩展名
            Console.WriteLine(Path.GetExtension(str));

            Console.ReadKey();


        }
    }
}
