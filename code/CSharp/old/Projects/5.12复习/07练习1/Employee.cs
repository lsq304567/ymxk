using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07练习1
{
    public class Employee:Person
    {
        public string Salary
        {
            get;
            set;
        }
        public override void SayHi()
        {
            Console.WriteLine("Employee，你好");
        }
    }
}
