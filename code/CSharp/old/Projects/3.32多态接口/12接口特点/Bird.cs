using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口特点
{
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }
}
