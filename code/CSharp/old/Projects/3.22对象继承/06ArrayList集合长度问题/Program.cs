using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ArrayList集合长度问题
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.ReadKey();


        }
    }
}
