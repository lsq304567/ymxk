using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    /// <summary>
    /// 抽象类
    /// </summary>
    internal abstract class AbClass
    {
        internal void IdentifyBase()
        {
            Console.WriteLine("I am AbClass.");
        }
        /// <summary>
        /// 抽象方法
        /// </summary>
        internal abstract void IdentifyDerived();
    }
}
