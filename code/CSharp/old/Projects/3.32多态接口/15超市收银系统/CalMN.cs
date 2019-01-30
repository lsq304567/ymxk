using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15超市收银系统
{
    /// <summary>
    /// 买M元 送N元
    /// </summary>
    class CalMN : CalFather
    {
        //买500 送100
        public double M
        {
            get; set;
        }
        public double N
        {
            get; set;
        }
        public CalMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetTotalMoney(double realMoney)
        {
            if (realMoney>=M)
            {
                return realMoney - (int)(realMoney / M) * N;
            }
            else
            {
                return realMoney;
            }
        }
    }
}
