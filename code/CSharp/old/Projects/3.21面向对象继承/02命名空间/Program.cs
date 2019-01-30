using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._21面向对象继承;

namespace _02命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            zsPerson.SatHellow();
            Console.ReadKey();
        }
    }
}
