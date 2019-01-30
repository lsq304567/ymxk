using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _09继承练习;

namespace _10关键字_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter rep = new Reporter("记者", 34, '男', "偷拍");
            rep.SayHellow();
            Console.ReadKey();


        }
    }
}
