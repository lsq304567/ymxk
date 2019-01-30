using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();

            //Student s = (Student)p;
            if (p is Student)
            {
                Student s = (Student)p;
                s.StudentSayHellow();
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            //Student s = p as Student;
            //s.StudentSayHellow();
            Console.ReadKey();

        }
    }
}
