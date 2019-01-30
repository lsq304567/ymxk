using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13File类
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Create(@"C:\Users\PC\Desktop\new.txt");
            Console.WriteLine("创建成功");

            Console.ReadKey();
        }
    }
}
