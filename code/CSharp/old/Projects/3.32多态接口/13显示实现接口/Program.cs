using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();
            fly.Fly();
            Console.ReadKey();
        }
    }
}
