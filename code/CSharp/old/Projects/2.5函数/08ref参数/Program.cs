using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary=5000;
            JiangLi(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }

        public static void JiangLi(ref double s)
        {
            s += 500;
        }

        public static void FaKuan(ref double s)
        {
            s -= 500;
        }
    }
}
