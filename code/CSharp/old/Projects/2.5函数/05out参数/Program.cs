 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max, min, num, avg;
            bool b;
            string str;
            double d;
            Test(numbers,out max,out min,out num,out avg,out b,out str,out d);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(num);
            Console.WriteLine(avg);
            Console.WriteLine(b);
            Console.WriteLine(str);
            Console.WriteLine(d);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算一个整数数组的最大值，最小值，总和，平均值
        /// </summary>
        /// <param name="nums">要求值的数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="num">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        /// <param name="b">多与返回的bool类型</param>
        /// <param name="str">多与返回string类型</param>
        /// <param name="d">多余返回的小数类型</param>
        public static void Test(int[] nums, out int max, out int min, out int num, out int avg, out bool b, out string str, out double d)
        {
            max = nums[0];
            min = nums[0];
            num = 0;
            for (int i=0;i<nums.Length;i++)
            {
                if(max<nums[i])
                {
                    max = nums[i];
                }
                if (min>nums[i])
                {
                    min = nums[i];
                }
                num += nums[i];
            }
            avg = num / nums.Length;
            b = true;
            str = "Hellow!";
            d = 3.1415926;
        }
    }
}
