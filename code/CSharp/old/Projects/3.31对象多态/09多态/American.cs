using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09多态
{
    public class American:Person
    {
        public American(string name) : base(name)
        {

        }
        public override void SayHellow()
        {
            Console.WriteLine("我叫{0}，我是米国人",this.Name);
        }
    }
}
