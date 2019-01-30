using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    /// <summary>
    /// 派生类 继承抽象类
    /// </summary>
    internal class DerivedClass : AbClass
    {
        internal override void IdentifyDerived()
        {
            Console.WriteLine("I am DerivedClass.");
        }
    }
}
