using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09匿名函数
{
    class Program
    {
        public delegate void DelSayHi(string name);
        static void Main(string[] args)
        {
            //DelSayHi del = delegate (string name)
            //  {
            //      Console.WriteLine("你好" + name);
            //  };
            DelSayHi del = (string name) => { Console.WriteLine("你好" + name); };
            del("张三");
            Console.ReadKey();


        }
    }
}
