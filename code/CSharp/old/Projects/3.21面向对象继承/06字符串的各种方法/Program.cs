using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你心中想的人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的人的名字长度是{0}", name.Length);
            //Console.ReadKey();



            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////lessonOne = lessonOne.ToUpper();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////lessonTwo = lessonTwo.ToUpper();
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们倆喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不相同");
            //}
            //Console.ReadKey();

            //string s = "a  b  c  adf_  ed  +  fdf  =  gg";
            //char[] chs = { ' ', '_', '+', '=' };
            //string[] str=s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();

            //string s = "2017-03-09";
            //string[] Date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", Date[0], Date[1], Date[2]);
            //Console.ReadKey();

            //string str = "国家关键人物老李";
            //if (str.Contains("老李"))
            //{
            //    str = str.Replace("老李", "**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "今天天气很好，处处好风光。";
            //str=str.Substring(3,1);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "今天天气很好天，处天处好天天风光。天";
            //string s = "天字所在的位置分别是：";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    i = str.IndexOf("天", i);
            //    s =s+i+"处";
            //}
            //Console.WriteLine(s);
            //Console.ReadKey();

            //string path = @"/s/d/a//sdf/sf/s/g/h/r/v/苍老师.wav";
            //int i = path.LastIndexOf("/");
            //path=path.Substring(++i);
            //Console.WriteLine(path);
            //Console.ReadKey();

            string[] str = { "张三", "李四", "王五", "赵六", "田七" };
            string strNew = string.Join("|", str);
            Console.WriteLine(strNew);
            Console.ReadKey();

        }
    }
}
