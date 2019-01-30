using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    public class Acer : NotoBook
    {
        public override void SayHellow()
        {
            Console.WriteLine("我是鸿基笔记本");
        }
    }
}
