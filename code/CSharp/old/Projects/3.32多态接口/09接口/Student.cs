using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09接口
{
    public class Student : Person, IKouLanable
    {
        public void KouLan()
        {
            Console.WriteLine("我也可以扣篮");
        }
    }
}
