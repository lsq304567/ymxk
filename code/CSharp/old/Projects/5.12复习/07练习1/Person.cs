using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07练习1
{
    public class Person
    {
        public string Name
        {
            get;
            set;
        }
        public char Gender
        {
            get; set;
        }
        public int Age
        {
            get;
            set;
        }
        public virtual void SayHi()
        {
            Console.WriteLine("Person，你好");
        }
    }
}
