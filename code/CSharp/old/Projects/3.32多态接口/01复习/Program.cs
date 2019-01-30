using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //虚方法 抽象类
            //学生可以起立  老师可以起立  校长可以起立

            //声明父类，去指定子类对象
            Person p = new Student();
            p.StandUp();
            Console.ReadKey();


        }
    }
}
