using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            TellStorry();
            Console.ReadKey();
        }
        public static int i = 0;
        public static void TellStorry()
        {
            Console.WriteLine("从前有座山");
            Console.WriteLine("山上有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天小和尚哭了，老和尚给小和尚讲了一个小故事");
            i++;
            if (i>=10)
            {
                return;
            }
            TellStorry();//回十次
        }
    }
}
