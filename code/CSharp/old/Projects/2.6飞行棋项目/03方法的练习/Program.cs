using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //100、计算任意多个数间的最大值（提示：params）。
            ////int[] nums = { 1, 5, 2, 3, 8, 4, 6, 9 };
            //int sum = GetSum(1, 5, 2, 8, 6, 3);
            //Console.WriteLine(sum);
            //Console.ReadKey(); 
            #endregion
            #region //101、请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Change(ref nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey(); 
            #endregion
            #region //102将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”(用方法来实现此功能)
            string[] strs = { "梅西", "卡卡", "郑大世" };
            ProcessString(ref strs);
            for (int i = 0; i < strs.Length; i++)
            {
                Console.Write(strs[i]);
            }
            Console.ReadKey();
            #endregion
        }
        /// <summary>
        /// 字符串方法加|
        /// </summary>
        /// <param name="strs"></param>
        public static void ProcessString(ref string[] strs)
        {
            string str = "|";
            for (int i = 0; i < strs.Length - 1; i++)
            {
                strs[i] = strs[i] + str;
            }
        }
        /// <summary>
        /// sort方法
        /// </summary>
        /// <param name="nums"></param>
        public static void Change(ref int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int jemp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = jemp;
                    }
                }
            }
        }
        /// <summary>
        /// 获得总和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int GetSum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
