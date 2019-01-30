using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03方法练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            //读取输入的整数，定义成方法，多次调用
            //如果输入为数字，则返回；否则提示用户重新输入
            Console.WriteLine("请输入一个数字");
            string str = Console.ReadLine();
            int num=Program.GetNumber(str);
            Console.WriteLine(num);
            Console.ReadKey();

        }
        /// <summary>
        /// 判断用户输入是否为整数
        /// 如果是整数，则返回
        /// 如果不是，则提示用户重新输入
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int num = Convert.ToInt32(s);
                    return num;
                }
                catch (Exception)
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }

    }
}
