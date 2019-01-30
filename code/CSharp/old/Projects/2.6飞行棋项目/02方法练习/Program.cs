using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 95、接受输入后判断其等级并显示出来
            //判断依据如下：等级={优 （90~100分）；良 （80~89分）
            //while (true)
            //{
            //    Console.WriteLine("请输入考试成绩");
            //    int score;
            //    bool b = int.TryParse(Console.ReadLine(), out score);
            //    while (b == false)
            //    {
            //        b = int.TryParse(Console.ReadLine(), out score);
            //    }
            //    string level = GetLevel(score);
            //    Console.WriteLine(level);
            //} 
            #endregion
            #region 97、请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转
            //string[] strs = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            ////array.reverse(strs);
            ////for (int i = 0; i < strs.Length / 2; i++)
            ////{
            ////    string temp = strs[i];
            ////    strs[i] = strs[strs.Length - 1 - i];
            ////    strs[strs.Length - 1 - i] = temp;
            ////}
            //Test(ref strs);
            //for (int i = 0; i < strs.Length; i++)
            //{
            //    Console.WriteLine(strs[i]);
            //}
            //Console.ReadKey();
            #endregion
            //98写一个方法 计算圆的面积和周长  面积是 pI*R*R  周长是 2*Pi*r
            Console.WriteLine("请输入圆的半径");
            double r = double.Parse(Console.ReadLine());
            double perimeter, area;
            GetPerimeterArea(r, out perimeter, out area);
            Console.WriteLine("半径为{0}的周长为{1}面积为{2}",r,perimeter,area);
            Console.ReadKey();
        }
        /// <summary>
        /// 计算圆的周长和面积
        /// </summary>
        /// <param name="r"></param>
        /// <param name="perimeter"></param>
        /// <param name="area"></param>
        public static void GetPerimeterArea(double r,out double perimeter,out double area)
        {
            double pi = 3.1415926;
            perimeter = 2 * pi * r;
            area = pi * r * r;
        }
        /// <summary>
        /// 反序执行
        /// </summary>
        /// <param name="strs"></param>
        public static void Test(ref string[] strs)
        {
            for (int i = 0; i < strs.Length / 2; i++)
            {
                string temp = strs[i];
                strs[i] = strs[strs.Length - 1 - i];
                strs[strs.Length - 1 - i] = temp;
            }
        }
        /// <summary>
        /// 判断成绩等级
        /// </summary>
        /// <param name="score"></param>
        /// <returns>返回成绩等级</returns>
        public static string GetLevel(int score)
        {
            string level = "";
            switch (score/10)
            {
                case 10:
                case 9:level = "优"; break;
                case 8:level = "良"; break;
                case 7:level = "中"; break;
                case 6:level = "差"; break;
                default:level = "不及格";
                    break;
            }
            return level;
        }
    }
}
