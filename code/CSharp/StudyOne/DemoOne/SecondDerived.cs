using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    /// <summary>
    /// 二级派生类
    /// </summary>
    class SecondDerived : MyDerivedClass
    {
        internal new void Print()
        {
            Console.WriteLine("This is the second derived class.");
        }
    }
}
