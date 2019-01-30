using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11泛型委托
{
    class Program
    {
        public delegate int DelCompare<T>(T t1, T t2);
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 2 };
            int max = GetMax<int>(nums, Compare);
            Console.WriteLine(max);
            Console.ReadKey();
        }
        public static T GetMax<T>(T[] nums, DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                //传一个比较的方法
                if (del(max, nums[i])<0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static int Compare(int n1,int n2)
        {
            return n1 - n2;
        }
    }
}
