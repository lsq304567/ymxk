using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04方法练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////只允许用户输入y或n，改成方法
            //Console.WriteLine("请输入yes或者no，否则重新输入");
            //string str = Console.ReadLine();
            //bool b=Program.Xuanze(str);
            //Console.WriteLine(b);
            //Console.ReadKey();

            //计算数组的总和：int Sum(int[] values)
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int sum=GetSum(nums);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算整数数组总和
        /// </summary>
        /// <param name="nums">输入的数组</param>
        /// <returns>返回总和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        /// <summary>
        /// 用户输入yes或者no
        /// yes返回true
        /// no返回false
        /// 否则重新输入
        /// </summary>
        /// <param name="str"></param>
        /// <returns>返回一个bool类型值</returns>
        public static bool Xuanze(string str)
        {
            while (true)
            {
                bool b;
                if (str == "yes")
                {
                    b = true;
                    return b;
                }
                else if (str == "no")
                {
                    b = false;
                    return b;
                }
                else
                {
                    str = Console.ReadLine();
                }
            }
        }

    }
}
