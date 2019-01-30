using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //M()
            Console.WriteLine(123);
            Console.ReadKey();
        }
        public static void M(int n1, int n2)
        {
            int result = n1 + n2;
        }
        public static double M(double n1, double n2)
        {
            return n1 + n2;
        }
        public static string M(string n1, string n2)
        {
            return n1 + n2;
        }
        public static int M(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

    }
}
