using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09多态
{
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Person (string name)
        {
            this.Name = name;
        }
        public virtual void SayHellow()
        {
            Console.WriteLine("我是人类");
        }


    }
}
