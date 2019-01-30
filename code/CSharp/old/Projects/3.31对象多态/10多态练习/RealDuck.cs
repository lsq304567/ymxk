using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    public class RealDuck
    {
        public virtual void Bark()
        {
            Console.WriteLine("真的鸭子嘎嘎叫");
        }
    }
}
