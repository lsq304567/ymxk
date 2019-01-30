using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04面向对象练习
{
    public class Student
    {
        ~Student()
        {
            Console.WriteLine("我是析构函数");
        }
        //构造函数
        public Student(string name,int age,char gender,int chinese,int math,int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        public Student(string name,int chinese,int math,int english):this(name,0,'男',chinese,math,english)
        {
        }
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
            set {
                if(value<0||value>100)
                {
                    value = 0;
                }
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get {
                if(_gender!='男'&&_gender!='女')
                {
                    _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set {
                if(value<0||value>100)
                {
                    value = 0;
                }
                _chinese = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _math = value; }
        }
        private int _english;
        public int English
        {
            get { return _english; }
            set {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _english = value; }
        }
        public void SayHellow()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);
        }
        public void ShowScore()
        {
            Console.WriteLine("我叫{0}，我的总成绩是{1}，我的平均成绩是{2}",this.Name,this.Chinese+this.Math+this.English,(this.Chinese + this.Math + this.English)/3);
        }
    }
}
