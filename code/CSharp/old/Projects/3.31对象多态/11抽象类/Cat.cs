using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11抽象类
{
    public class Cat:Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }
    }
}
