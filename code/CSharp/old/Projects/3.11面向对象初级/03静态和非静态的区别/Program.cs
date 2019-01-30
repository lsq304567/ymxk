using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03静态和非静态的区别
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Person p = new Person();
            p.M1();
            Person.M2();

            Console.ReadKey();
        }
    }
}
