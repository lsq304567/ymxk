using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03静态和非静态的区别
{
    public static class Student
    {
        private static string _name;
        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private static char _gender;
        public static char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
    }
}
