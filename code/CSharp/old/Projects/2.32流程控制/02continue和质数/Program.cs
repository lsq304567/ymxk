using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02continue和质数
{
    class Program
    {
        static void Main(string[] args)
        {
            //找出100内所有的素数
            for (int i = 2; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.WriteLine("100以内的质数有{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
