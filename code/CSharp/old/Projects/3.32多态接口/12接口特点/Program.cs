using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();// new Person();
            fly.Fly();
            Console.ReadKey();


        }
    }
}
