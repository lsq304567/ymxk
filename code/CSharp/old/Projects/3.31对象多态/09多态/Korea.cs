using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09多态
{
    public class Korea:Person
    {
        public Korea(string name) : base(name)
        {

        }
        public override void SayHellow()
        {
            Console.WriteLine("我是棒子思密达，我叫{0}", this.Name);
        }
    }
}
