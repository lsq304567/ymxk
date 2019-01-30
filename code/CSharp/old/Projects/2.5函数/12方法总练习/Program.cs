using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12方法总练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //提示用户输入两个数字，计算这两个整数之间所有的整数和
            //1用户只能输入数字
            //2计算两个数字之间的和
            //3要求第一个数字必须比第二个数字小，否则重新输入
            Console.WriteLine("请输入第一个数字");
            string strNumberOne = Console.ReadLine();
            int numberOne = GetNumber(strNumberOne);
            Console.WriteLine("请输入第二个数字");
            string strNumberTwo = Console.ReadLine();
            int numberTwo = GetNumber(strNumberTwo);
            JudgeNumber(ref numberOne,ref numberTwo);//判断第一个数字是否小于第二个数字
            int sum = GetSum(numberOne, numberTwo);//求和
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        public static int GetSum(int n1,int n2)
        {
            int sum = 0;
            for (int i = n1; i <= n2; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static void JudgeNumber(ref int n1,ref int n2)
        {
            while (true)
            {
                if (n1<n2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("第一个数字不能大于等于第二个数字，请重新输入第一个数字");
                    string s1 = Console.ReadLine();
                    n1 = GetNumber(s1);
                    Console.WriteLine("请输入第二个数字");
                    string s2 = Console.ReadLine();
                    n2 = GetNumber(s2);

                }
            }
        }
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int num = int.Parse(s);
                    return num;
                }
                catch
                {
                    Console.WriteLine("输入有误！！！请重新输入。");
                    s = Console.ReadLine();
                }
            }
        }
    }
}
