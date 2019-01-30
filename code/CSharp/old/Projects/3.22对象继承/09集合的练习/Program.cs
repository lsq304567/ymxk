using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合，里面添加一些数字，求和与平均值
            //ArrayList list = new ArrayList();
            //list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            //int num = 0;
            //for (int i = 0; i < list.Count; i++)
            //{
            //    num += (int)list[i];
            //}
            //Console.WriteLine("和为：{0}，平均值为：{1}", num, num / list.Count);
            //int max = (int)list[0];
            //int min = (int)list[0];
            //for (int i = 1; i < list.Count; i++)
            //{
            //    if (max<(int)list[i])
            //    {
            //        max = (int)list[i];
            //    }
            //    if (min>(int)list[i])
            //    {
            //        min = (int)list[i];
            //    }
            //}
            //Console.WriteLine("最大值为：{0}，最小值为：{1}", max, min);
            //Console.ReadKey();


            //写一个长度为10的集合，要求在里面随机地存放10个数字（0 - 9），但是要求所有的数字不重复
            ArrayList list = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rNumber = r.Next(0, 10);
                if (!list.Contains(rNumber))
                {
                    list.Add(rNumber);
                }
                else
                {
                    i--;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();


        }
    }
}
