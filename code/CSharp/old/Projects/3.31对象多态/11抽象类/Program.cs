using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗狗会叫  猫咪会叫
            Animal a = new Cat();
            a.Bark();
            Console.ReadKey();


        }
    }
}
