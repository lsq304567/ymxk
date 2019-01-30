using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._21面向对象继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person("张三",18,Person._Gender.女);
            //new  1在内存中开辟一片空间   2.在空间中创建一个面向对象   3.调用构造函数
            zsPerson.SatHellow();
            Person.SatHellowTwo();
            Person lsPerson = new Person("李四", Person._Gender.男);
            lsPerson.SatHellow();
            Console.ReadKey();
        }
    }
}
