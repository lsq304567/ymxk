using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 方法练习78
            //79、用方法来实现：有一个字符串数组：
            //{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = GetLongest(names);
            //Console.WriteLine(max);
            //Console.ReadKey(); 
            #endregion
            #region 方法练习80
            //  80、用方法来实现：请计算出一个整型数组的平均值。保留两位小数
            //int[] nums = { 5, 3, 2, 1, 8, 5, 6, 4, 1 };
            //double avg = GetAvg(nums);
            //string s = avg.ToString("0.00");
            ////Console.WriteLine(s);
            //avg = double.Parse(s);
            ////Console.WriteLine("{0:0.00}",avg);
            //Console.WriteLine(avg);
            //Console.ReadKey(); 
            #endregion
            //1、写一个方法，用来判断用户输入的数字是不是质数  
            //再写一个方法 要求用户只能输入数字 输入有误就一直让用户输入
            while (true)
            {
                Console.WriteLine("请输入一个数字，我们将判断您输入的数字是否为质数");
                string str = Console.ReadLine();
                int num = GetNumber(str);
                bool b = IsPrime(num);
                Console.WriteLine(b);
            }
            //Console.ReadKey();
        }
        /// <summary>
        /// 获得数字
        /// </summary>
        /// <param name="strNumber">字符串参数</param>
        /// <returns>返回整数</returns>
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int num = int.Parse(strNumber);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入有误，请重新输入数字");
                    strNumber = Console.ReadLine();
                }
            }
        }
        /// <summary>
        /// 判断是否为质数
        /// </summary>
        /// <param name="num"></param>
        /// <returns>返回bool类型</returns>
        public static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;//非质数
                    }
                }
                return true;//质数
            }
        }
        /// <summary>
        /// 计算整形数组平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static double GetAvg(int[] nums)
        {
            double sum = 0, avg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            avg = sum / nums.Length;
            return avg;
        }
        /// <summary>
        /// 选择字符串数组最长字符串
        /// </summary>
        /// <param name="names"></param>
        /// <returns>返回最长字符串</returns>
        public static string GetLongest(string[] names)
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > max.Length)
                {
                    max = names[i];
                }
            }
            return max;
        }
    }
}
