using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    public class Dell : NotoBook
    {
        public override void SayHellow()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
}
