using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    public class Teacher : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("老师起立，说校长好");
        }
    }
}
