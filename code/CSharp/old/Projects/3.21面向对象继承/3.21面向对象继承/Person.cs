using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._21面向对象继承
{
    public class Person
    {
        string _name;
        /// <summary>
        /// 属性的本质就是两个方法
        /// </summary>
        public string Name
        {
            get { return _name; }
            set {
                if (value!="孙权")
                {
                    value = "孙权";
                }
                _name = value; }
        }
        int _age;
        public int Age
        {
            get {
                if (_age<0||_age>100)
                {
                    _age = 0;
                }
                return _age; }
            set { _age = value; }
        }
        _Gender _gender;
        public _Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public enum _Gender
        {
            男,
            女
        }
        public void SatHellow()
        {
            Console.WriteLine("{0},{1},{2}", this.Name, this.Age, this.Gender);
        }
        public static void SatHellowTwo()
        {
            Console.WriteLine("Hellow!我是静态方法");
        }
        public Person(string name, int age, _Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public Person(string name,_Gender gender):this(name,0,gender)
        {

        }
        public Person(string name) : this(name, _Gender.男)
        {

        }
        public Person()
        {
        }
    }
}
