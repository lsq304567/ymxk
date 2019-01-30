using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛型集合对象
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //int[] nums= list.ToArray();//集合转换为数组

            char[] chs = new char[] { 'a', 'b', 'c' };
            List<char> listChar= chs.ToList();//数组转换为集合

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();


        }
    }
}
