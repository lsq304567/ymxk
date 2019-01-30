using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02枚举
{
    public enum QQState
    {
        OnLine = 1,
        OffLine,
        Leave,
        Busy,
        QMe
    }
    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型转换为int类型
            //QQState state = QQState.OnLine;
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion
            #region 将int类型转换为枚举类型
            //int n1 = 3;
            //QQState state1 = (QQState)n1;
            //Console.WriteLine(n1);
            //Console.ReadKey();
            #endregion
            #region 将枚举类型转换为string类型
            //所有类型都能转换为string
            //int n1 = 3;
            //double n1 = 3.14;
            //decimal n1 = 152m;
            //string state1 = n1.ToString();
            //Console.WriteLine(state1);
            //Console.ReadKey();

            //QQState state1 = QQState.OnLine;
            //Console.WriteLine(state1.ToString());
            //Console.ReadKey();
            #endregion
            #region 将字符串转换为枚举类型
            //string s = "0";
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion
            #region 枚举练习
            Console.WriteLine("请选择您qq在线状态：1---online  2---dffline  3---leave  4---busy  5---gme");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("您选择的在线状态是{0}", (QQState)Enum.Parse(typeof(QQState), input));
                    break;
                case "2":
                    Console.WriteLine("您选择的在线状态是{0}", (QQState)Enum.Parse(typeof(QQState), input));
                    break;
                case "3":
                    Console.WriteLine("您选择的在线状态是{0}", (QQState)Enum.Parse(typeof(QQState), input));
                    break;
                case "4":
                    Console.WriteLine("您选择的在线状态是{0}", (QQState)Enum.Parse(typeof(QQState), input));
                    break;
                case "5":
                    Console.WriteLine("您选择的在线状态是{0}", (QQState)Enum.Parse(typeof(QQState), input));
                    break;
                default:
                    Console.WriteLine("您输入格式错误，程序退出");
                    break;
            }
            Console.ReadKey();
            #endregion

            //Gender gender = Gender.男;
            //Console.WriteLine(gender);
            //Console.ReadKey();
        }
    }
}
