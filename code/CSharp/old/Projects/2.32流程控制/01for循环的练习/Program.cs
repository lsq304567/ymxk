using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01for循环的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 练习1
            //练习1: 循环录入5个人的年龄并计算平均年龄,如果录入的数据出现负数或大于100的数,立即停止输入并报错.
            int age = 0, sum = 0;
            bool bc = true;
            Console.WriteLine("请输入5个人的年龄");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("请输入的第{0}个人的年龄", i);
                bool b = int.TryParse(Console.ReadLine(), out age);
                if (b == true)
                {
                    if (age > 0 && age < +100)
                    {
                        sum += age;
                    }
                    else
                    {
                        Console.WriteLine("录入数据出现负数或者大于100，程序退出");
                        bc = false;
                        break;
                    }
                }//if布尔b括号
                else
                {
                    Console.WriteLine("输入错误，请重新输入");
                    i--;
                }
            }//for括号
            if (bc)
            {
                Console.WriteLine("输入的5个人平均年龄为{0}", sum / 5);
            }
            Console.ReadKey();
            #endregion
            #region 练习2
            //////练习2：在while中用break实现要求用户一直输入用户名和密码，只要不是admin、88888就一直提示要求重新输入,如果正确则提登录成功.
            ////string user = "", password = "";
            ////do
            ////{
            ////    Console.WriteLine("请输入用户名");
            ////    user = Console.ReadLine();
            ////    Console.WriteLine("请输入密码");
            ////    password = Console.ReadLine();
            ////} while (user != "admin" && password != "88888");
            ////Console.WriteLine("登陆成功");
            ////Console.ReadKey();

            //string user = "", password = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    user = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    password = Console.ReadLine();
            //    if (user == "admin" && password == "88888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户或者密码输入错误，请重新输入");
            //    }
            //}
            //Console.ReadKey();
            #endregion
            #region 练习3
            ////1~100之间的整数相加，得到累加值大于20的当前数(比如:1+2+3+4+5+6=21)结果6
            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum >= 20)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey(); 
            #endregion
        }
    }
}
