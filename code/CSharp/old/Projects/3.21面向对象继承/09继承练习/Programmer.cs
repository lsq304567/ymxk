using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承练习
{
    public class Programmer:Person
    {
        private int _workYear;
        public int WorkYear
        {
            get { return _workYear; }
            set { _workYear = value; }
        }
        public void ProgrammerSayHellow()
        {
            Console.WriteLine("我叫{0}，我是一名程序员，我是{1}生，我今年{2}岁了，我的工作年限是{3}年",this.Name, this.Gender, this.Age, this.WorkYear);
        }
        public Programmer(string name,int age,char gender,int workYear) : base(name, age, gender)
        {
            this.WorkYear = workYear;
        }
        public new void SayHellow()
        {
            Console.WriteLine("大家好，我是程序员");
        }


    }
}
