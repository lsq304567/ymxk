using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15超市收银系统
{
    /// <summary>
    /// 打折父类
    /// </summary>
    abstract class CalFather
    {
        /// <summary>
        /// 计算打折后应付的价钱
        /// </summary>
        /// <param name="realMoney">打折前的价钱</param>
        /// <returns>打折后应付的钱</returns>
        public abstract double GetTotalMoney(double realMoney);
    }
}
