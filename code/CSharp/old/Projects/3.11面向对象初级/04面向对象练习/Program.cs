using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Student zsStudent = new Student("张三",19,'里',-9,100,120);
            //zsStudent.Name = "张三";
            //zsStudent.Age = 18;
            //zsStudent.Gender = '里';
            //zsStudent.Chinese = -5;
            //zsStudent.Math = 100;
            //zsStudent.English = 120;
            zsStudent.SayHellow();
            zsStudent.ShowScore();

            Student xmStudent = new Student("小明", 50, -5, 50);
            xmStudent.ShowScore();

            Student xhStudent = new Student("小华",15,'女',50,50,50);
            //xhStudent.Name = "小华";
            //xhStudent.Age = 12;
            //xhStudent.Gender = '女';
            //xhStudent.Chinese = 50;
            //xhStudent.Math = 50;
            //xhStudent.English = 50;
            xhStudent.SayHellow();
            xhStudent.ShowScore();

            Console.ReadKey();
        }
    }
}
