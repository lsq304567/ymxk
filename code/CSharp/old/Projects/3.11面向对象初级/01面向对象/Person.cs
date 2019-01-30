using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _age = value;
            }
        }
        Gender1 _gender;
        public Gender1 Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public enum Gender1
        {
            男,
            女
        }

        public void CHLSS()
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，我是{2}生，我能吃喝拉撒睡呦！！！！！！！！！", this.Name, this.Age, this.Gender);
        }
    }
}
