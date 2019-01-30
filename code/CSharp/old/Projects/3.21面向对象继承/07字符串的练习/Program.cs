using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习4：文本文件中存储了多个文章标题、作者，标题和作者之间用若干空格（数量不定）隔开，每行一个，标题有的长有的短，输出到控制台的时候最多标题长度10，如果超过10，则截取长度8的子串并且最后添加“...”，加一个竖线后输出作者的名字。

            //string path = @"G:\txt1.txt";
            //string[] contents = File.ReadAllLines(path, Encoding.Default);
            ////char[] chs = { ' ' };
            //for (int i = 0; i < 4; i++)
            //{
            //    string[] str = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    if (str[0].Length > 9)
            //    {
            //        Console.WriteLine(str[0].Substring(0, 8) +"...|" + str[1]);
            //    }
            //    else
            //    {
            //        Console.WriteLine(str[0] + '|' + str[1]);
            //    }
            //}
            //Console.ReadKey();


            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"

            //Console.WriteLine("请输入一段文字，将被反转");
            //string str = Console.ReadLine();
            //char[] chs = str.ToCharArray();
            ////for (int i = 0; i < str.Length; i++)
            ////{
            ////    chs[i] = str.Substring(i, 1);
            ////}
            //for (int i = 0; i < str.Length / 2; i++)
            //{
            //    char temp;
            //    temp = chs[i];
            //    chs[i] = chs[str.Length - 1 - i];
            //    chs[str.Length - 1 - i] = temp;
            //}
            ////for (int i = 0; i < str.Length; i++)
            ////{
            ////    Console.Write(chs[i]);
            ////}
            //str = new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey();


            //课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。"hello c sharp"→"sharp c hello"
            //Console.WriteLine("输入一段英文");            //string s = Console.ReadLine();            //string[] str = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < str.Length / 2; i++)
            //{
            //    string temp= str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i] = temp;
            //}
            //s = string.Join(" ", str);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //课上练习3：从Email中提取出用户名和域名：abc@163.com。
            //string str = "abc@163.com";
            //int s = str.IndexOf('@');
            //string name = str.Substring(0, s);
            //string urlOne = str.Substring(s+1);
            //Console.WriteLine("用户名：{0},域名：{1}", name, urlOne);
            //Console.ReadKey();


            //让用户输入一句话,找出所有e的位置
            //Console.WriteLine("请输入一句话，包含有e");
            //string str = Console.ReadLine();
            //if (str.IndexOf('e') == -1)
            //{
            //    Console.WriteLine("该字符串不包含e");
            //}
            //else
            //{
            //    int m = 0;
            //    for (int i = 0; i < str.LastIndexOf('e');i++)
            //    {
            //        i = str.IndexOf('e', i);
            //        m++;
            //        Console.WriteLine("第{0}个e的位置为{1}", m, i);
            //    }
            //}
            //Console.ReadKey();



            //让用户输入一句话, 判断这句话中有没有邪恶, 如果有邪恶就替换成这种形式然后输出, 如:老牛很邪恶,
            //输出后变成老牛很 * *;
            //Console.WriteLine("请输入一句话，包含‘邪恶’");
            //string str = Console.ReadLine();
            //if (str.Contains("邪恶"))
            //{
            //    str = str.Replace("邪恶", "**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();



            //把{“诸葛亮”,”鸟叔”,”卡卡西”,”卡哇伊”}
            //变成诸葛亮 | 鸟叔 | 卡卡西 | 卡哇伊,然后再把 | 切割掉
            string[] str = { "诸葛亮", "鸟叔", "卡卡西", "卡哇伊" };
            string s = string.Join("|", str);
            Console.WriteLine(s);
            str = s.Split('|', ' ');
            s = string.Join("", str);
            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}
