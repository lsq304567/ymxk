using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06数组的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习一
            ////练习1：从一个整数数组中取出最大的整数,最小整数,总和,平均值
            //int[] nums = new int[8] { 8, 6, 18, 49, 5, 6, 4, 15 };
            //int numMax = nums[0], numFar = nums[0], total = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (numMax <= nums[i])
            //    {
            //        numMax = nums[i];
            //    }
            //    if (numFar > nums[i])
            //    {
            //        numFar = nums[i];
            //    }
            //    total += nums[i];
            //}//for括号
            //Console.WriteLine("整个数组中最大整数是{0}最小整数是{1}，总和为{2}，平均数为{3}", numMax, numFar, total, total / (nums.Length));
            //Console.ReadKey();
            #endregion
            #region 练习3
            ////练习3:数组里面都是人的名字,分割成:例如:老杨|老苏|老邹…”
            ////(老杨, 老苏, 老邹, 老虎, 老牛, 老蒋, 老王, 老马)
            //string[] names = { "老杨", "老苏", "老邹", "老虎", "老牛", "老蒋", "老王", "老马" };
            //string str = null;
            //for (int i = 0; i < names.Length - 1; i++)
            //{
            //    str += names[i] + '|';
            //}
            //str += names[names.Length - 1];
            //Console.WriteLine(str);
            //Console.ReadKey();
            #endregion
            #region 练习4
            ////练习4：将一个整数数组的每一个元素进行如下的处理：如果元素是正数则将这个位置的元素的值加1，
            ////如果元素是负数则将这个位置的元素的值减1,如果元素是0,则不变。
            //int[] nums = { 1, -8, -5, 51, -48, 5, -64, 0 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i]++;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        nums[i]--;
            //    }
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();
            #endregion
            #region 练习5
            //练习5：将一个字符串数组的元素的顺序进行反转。{“我”,“是”,”好人”}
            //{“好人”,”是”,”我”}。第i个和第length - i - 1个进行交换。
            string[] names = { "我", "是", "好人" };
            for (int i = 0; i <= names.Length / 2; i++)
            {
                string middle = names[i];
                names[i] = names[names.Length - i - 1];
                names[names.Length - i - 1] = middle;
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i]);
            }
            Console.ReadKey(); 
            #endregion
        }
    }
}
