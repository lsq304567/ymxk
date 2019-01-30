using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Program.GetMax(5, 8);
            Console.WriteLine(max);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算两个整数之间的最大值，并且将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>将最大值返回</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

    }
}
