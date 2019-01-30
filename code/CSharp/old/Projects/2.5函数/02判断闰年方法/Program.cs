using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02判断闰年方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年份，判断是负为闰年");
            int year = 0;
            bool a = int.TryParse(Console.ReadLine(),out year);
            if (a == false)
            {
                Console.WriteLine("输入有误，程序退出");
            }
            else
            {
                bool b = Program.IsRun(year);
                if (b == true)
                {
                    Console.WriteLine("{0}输入的年份为闰年", year);
                }
                else
                {
                    Console.WriteLine("{0}输入的年份不是闰年", year);
                }
            }
            Console.ReadKey();

        }
        /// <summary>
        /// 传入一个年份判断是否为闰年
        /// </summary>
        /// <param name="year">传入的年份</param>
        /// <returns>返回bool类型值</returns>
        public static bool IsRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
    }
}
