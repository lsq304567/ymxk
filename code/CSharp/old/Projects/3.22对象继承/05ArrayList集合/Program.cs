using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            //list.Add(3.14);
            //list.Add("张三");
            //list.Add('男');
            //list.Add(5000m);
            list.Add(true);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            list.AddRange(list);
            //list.Clear();
            //list.Remove(true);
            //list.RemoveAt(1);
            //list.RemoveRange(1, 2);
            list.Insert(2, "插入的");
            list.InsertRange(3, new string[] { "张三", "李四" });

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();


        }
    }
}
