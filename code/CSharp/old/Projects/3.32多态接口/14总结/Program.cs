using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14总结
{
    class Program
    {
        static void Main(string[] args)
        {
            //什么时候用虚方法来实现多态
            //什么时候用抽象类来实现多态
            //什么时候用接口来实现多态

            //真的鸭子会游泳  木头鸭子不会游泳  橡皮鸭子会游泳
            ISwimmingable dk = new Duck();
            dk.Swimming();
            ISwimmingable xp = new XPDuck();
            xp.Swimming();
            Console.ReadKey();

        }
    }
}
