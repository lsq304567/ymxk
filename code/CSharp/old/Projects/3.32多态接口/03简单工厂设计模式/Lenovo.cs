using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    public class Lenovo : NotoBook
    {
        public override void SayHellow()
        {
            Console.WriteLine("我是联想笔记本，你联想也别想");
        }
    }
}
