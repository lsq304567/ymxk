using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08继承
{
    public class Teacher:Person
    {
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public void Teach()
        {
            Console.WriteLine("老师会讲课");
        }
        public Teacher(string name, int age, char gender, double Salary) : base(name, age, gender)
        {
            this.Salary = Salary;
        }
    }
}
