using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08委托概念
{
    class Program
    {
        //声明一个委托指向一个函数
        public delegate void DelSayHi(string name);
        static void Main(string[] args)
        {
            //DelSayHi del = SayHiEnglish;//new DelSayHi(SayHiChinese);
            //Test("张三",del);
            Test("张三", SayHiChinese);
            Console.ReadKey();


        }
        public static void Test(string name, DelSayHi del)
        {
            //调用
            del(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了吗？" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you," + name);
        }

    }
}
