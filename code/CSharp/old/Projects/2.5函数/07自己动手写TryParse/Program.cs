using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07自己动手写TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string str = Console.ReadLine();
            //bool b = int.TryParse("123", out num);
            bool b = Test(str, out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        /// <summary>
        /// 将string类型转换为int类型
        /// 成功 true
        /// 失败 false
        /// </summary>
        /// <param name="str">要转换的参数</param>
        /// <param name="num">多与返回的转换值</param>
        /// <returns>返回转换是否成功结果</returns>
        public static bool Test(string str, out int num)
        {
            try
            {
                num = int.Parse(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;
            }
        }
    }
}
