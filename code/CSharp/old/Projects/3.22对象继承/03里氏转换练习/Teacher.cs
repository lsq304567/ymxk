using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03里氏转换练习
{
    public class Teacher:Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }
    }
}
