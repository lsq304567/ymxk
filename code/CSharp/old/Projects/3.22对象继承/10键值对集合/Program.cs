using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, '男');
            ht.Add(3, 2);
            ht.Add(true, 2153m);
            ht[4] = "新来的";
            ht[1] = "干掉张三";

            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }
            Console.ReadKey();
        }
    }
}
