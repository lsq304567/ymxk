using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    public class MuDuck:RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }
}
