using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    public class Student : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("学生起立，说老师好");
        }
    }
}
