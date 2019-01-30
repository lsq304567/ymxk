using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05修改后的年份
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要查询的年份");
            int year = 0;
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入需要查询的月份");
                int month = 0;
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if ((month >= 1) && (month <= 12))
                    {
                        int day = 0;
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12: day = 31; break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            default:
                                day = 30;
                                break;
                        }//switch括号
                        Console.WriteLine("您输入的{0}年{1}月有{2}天", year, month, day);
                    }//if括号
                    else
                    {
                        Console.WriteLine("输入的月份不符合要求，程序退出");
                    }
                }//try月份
                catch
                {
                    Console.WriteLine("输入的月份有误，程序退出");
                }
            }//try年份的括号
            catch
            {
                Console.WriteLine("输入的年份有误，程序退出");
            }
            Console.ReadKey();
        }
    }
}
