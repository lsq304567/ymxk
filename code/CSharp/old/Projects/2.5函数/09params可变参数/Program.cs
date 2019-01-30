using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("张三", 88, 99, 77);
            Console.ReadKey();
        }
        public static void Test(string name,params int[] s)
        {
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += s[i];
            }
            Console.WriteLine("{0}这次的总成绩为{1}",name,sum);
        }
    }
}
