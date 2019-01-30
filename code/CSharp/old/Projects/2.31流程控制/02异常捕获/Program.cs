using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            int number = 0;//声明
            Console.WriteLine("请输入一个数字");
            #region 异常捕获，踹它一脚
            try
            {
                number = Convert.ToInt32(Console.ReadLine());//赋值
            }
            catch
            {
                Console.WriteLine("输入的内容不能转换为数字");
                b = false;
            } 
            #endregion
            if (b == true)//判断是否发生异常，异常则不执行
            {
                Console.WriteLine(number * 2);//使用
            }
            Console.ReadKey();
        }
    }
}
