using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    public class XPDuck:RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }
}
