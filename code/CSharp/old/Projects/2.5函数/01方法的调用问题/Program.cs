using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01方法的调用问题
{
    class Program
    {
        public static int _number = 10;
        static void Main(string[] args)
        {
            int a = 5;
            a=Program.Test(a);//实参
            Console.WriteLine(a);
            Console.ReadKey();

        }
        public static int Test(int a)//形参
        {
            a = a + 1;
            Console.WriteLine(_number);
            return a;
        }
    }
}
