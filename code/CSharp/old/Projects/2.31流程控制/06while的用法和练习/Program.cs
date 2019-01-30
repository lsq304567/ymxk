using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06while的用法和练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //01 循环体：提示用户输入学员成绩 接收     循环条件：输入数小于班级人数
            #region 01求总成绩和平均成绩
            int classSize = 0, score = 0, totalScore = 0, averageScore = 0;
            int i = 1;
            Console.WriteLine("请输入班级人数");
            try
            {
                classSize = Convert.ToInt32(Console.ReadLine());
                while (i <= classSize)
                {
                    Console.WriteLine("请输入第{0}个学员成绩", i);
                    try
                    {
                        score = Convert.ToInt32(Console.ReadLine());
                        totalScore += score;
                        i++;
                    }//try学员成绩
                    catch
                    {
                        Console.WriteLine("输入成绩有误");
                    }
                }//while括号
                averageScore = totalScore / classSize;
                Console.WriteLine("该班级有{0}人，总成绩{1}分，平均成绩{2}分", classSize, totalScore, averageScore);
            }//try班级人数括号
            catch
            {
                Console.WriteLine("输入的班级人数有误，程序退出");
            }
            Console.ReadKey();
            #endregion

            //老师问学生, 这道题你会做了吗?如果学生答"会了(y)",则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
            // 直到学生会为止,才可以放学.
            // 直到学生会或老师给他讲了10遍还不会,都要放学
            //02循环体：询问学生会做了吗  接收y n       循环条件：接收值为n
            #region 学生会作业，放学
            //string answer;
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("老师询问学生，这道题会做了吗？会了输入“y”不会输入“n”，{0}", i);
            //    answer = Console.ReadLine();
            //    if (answer == "y")
            //    {
            //        break;
            //    }
            //    if (i != 10)
            //    {
            //        Console.WriteLine("那就再讲一遍");
            //    }
            //    i++;
            //}//while括号
            //Console.WriteLine("那现在放学");
            //Console.ReadKey();  
            #endregion

            #region 培训学员速度
            ////2006年培养学员80000人，每年增长25 %，请问按此增长速度，到哪一年培训学员人数将达到20万人？
            ////03循环体：
            //int year = 2006;
            //double student = 80000;
            //Console.WriteLine("2006年培养学员80000人，每年增长25 %");
            //while (student <= 200000)
            //{
            //    student *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("按此增长速度，到{0}年培训学员人数将达到20万人", year);
            //Console.ReadKey(); 
            #endregion
        }
    }
}
