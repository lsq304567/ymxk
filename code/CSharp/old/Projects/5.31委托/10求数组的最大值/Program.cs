using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10求数组的最大值
{
    class Program
    {
        public delegate int DelCompare(object o1, object o2);
        static void Main(string[] args)
        {
            object[] o = { 1, 2, 3, 4, 5 };
            object result = GetMax(o, Compare);
            Console.WriteLine(result);
            Console.ReadKey();


        }
        public static object GetMax(object[] nums,DelCompare del)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                //传一个比较的方法
                if (del(max,nums[i])<0)
                {
                    max = nums[i];
                }
            }
            return max;
        }
        public static int Compare(object o1, object o2)
        {
            int n1 = (int)o1;
            int n2 = (int)o2;
            return n1 - n2;
        }

    }
}
