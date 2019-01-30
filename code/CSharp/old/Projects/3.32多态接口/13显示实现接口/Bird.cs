using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13显示实现接口
{
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("我是鸟的飞");
        }
        void IFlyable.Fly()
        {
            Console.WriteLine("我是接口的飞");
        }
    }
}
