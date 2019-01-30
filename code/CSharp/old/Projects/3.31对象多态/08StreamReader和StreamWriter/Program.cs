using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //用StreamReader来读取一个文件
            //using (StreamReader sr = new StreamReader(@"C:\Users\PC\Desktop\new.txt", Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}
            Console.ReadKey();

            using (StreamWriter sw = new StreamWriter(@"C:\Users\PC\Desktop\newnew.txt",true))
            {
                sw.Write("看我有没有把你覆盖");
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
