using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11抽象类
{
    public class Dog:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }
    }
}
