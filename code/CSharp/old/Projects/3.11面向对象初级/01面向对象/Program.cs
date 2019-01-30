using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建Person类的对象 new
            Person sunQuan = new Person();
            sunQuan.Name = "孙权";
            sunQuan.Age = 150;
            sunQuan.Gender = Person.Gender1.男; 
            sunQuan.CHLSS();
            Console.ReadKey();

        }
    }
}
