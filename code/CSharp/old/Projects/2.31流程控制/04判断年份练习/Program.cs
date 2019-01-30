using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04判断年份练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输年份,再输入月份,输出该月的天数.(结合之前如何判断闰年来做)
            //润年的判定(符合下面两个条件之一):
            //年份能够被400整除.(2000)
            //年份能够被4整除但不能被100整除.(2008)
            //31天：1,3,5,7,8,10，12
            //30天：4,6,9,11
            //2月
            #region 输入年份
            Console.WriteLine("请输入需要查询的年份");
            int year = 0;
            bool bYear = true;
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的年份有误，不能转换为数字");
                bYear = false;
            }
            #endregion
            #region 输入月份
            Console.WriteLine("请输入需要查询的月份");
            int month = 0;
            bool bMonth = true;
            try
            {
                month = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的月份有误，不能转换为数字");
                bMonth = false;
            } 
            #endregion
            bool b = (year % 400 == 0) || (year % 4 == 0) && (year % 100 != 0);//判断闰年
            #region 判断天数
            int day = 0;
            bool bDay = true;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: day = 31; break;
                case 4:
                case 6:
                case 9:
                case 11: day = 30; break;
                case 2:
                    if (b == true)
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default: Console.WriteLine("您输入的月份有误，程序退出");
                    bDay = false;
                    break;
            }
            bool bZ = (bYear == true)&& (bMonth == true) &&( b == true) && (bDay == true);
            #endregion
            if (bZ==true)
            {
                Console.WriteLine("您输入的{0}年{1}月有{2}天", year, month, day);
            }
                Console.ReadKey();
        }
    }

}


