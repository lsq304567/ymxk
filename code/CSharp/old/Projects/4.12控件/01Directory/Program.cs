using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //File  Path  FileStream  StreamReader  StreamWriter
            //Directory 文件夹，目录
            //创建文件夹
            //Directory.CreateDirectory(@"F:\a");
            //Console.WriteLine("创建成功");
            //Console.ReadKey();

            //删除文件夹
            //Directory.Delete(@"F:\a",true);
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

            //剪切文件夹
            //Directory.Move(@"F:\a", @"F:\ceshi");
            //Console.WriteLine("移动成功");
            //Console.ReadKey();

            //获得指定文件夹下文件的全路径
            //string[] path= Directory.GetFiles(@"C:\Users\PC\Desktop\Picture","*.jpg");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();

            //获得指定目录下所有文件夹的全路径
            //string[] path= Directory.GetDirectories(@"C:\Users\PC\Desktop\a");
            //for (int i = 0; i < path.Length; i++)
            //{
            //    Console.WriteLine(path[i]);
            //}
            //Console.ReadKey();

            //判断指定的文件夹是否存在
            //if (Directory.Exists(@"C:\Users\PC\Desktop\a\b"))
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Directory.CreateDirectory(@"C:\Users\PC\Desktop\a\b\" + i);
            //    }
            //}
            //Console.WriteLine("OK");
            //Console.ReadKey();

            Directory.Delete(@"C:\Users\PC\Desktop\a\b", true);
            Console.ReadKey();




        }
    }
}
