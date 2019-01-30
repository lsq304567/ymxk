using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09多态
{
    public class Japanese:Person
    {
        public Japanese(string name) : base(name)
        {
           
        }
        public override void  SayHellow()
        {
            Console.WriteLine("我是脚盆国人，我叫{0}", this.Name);
        }
    }
}
