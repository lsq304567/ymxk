using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05泛型集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示在左边 偶数显示在右边。
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listOne = new List<int>();
            //List<int> listTwo = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i]%2==1)
            //    {
            //        listOne.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listTwo.Add(nums[i]);
            //    }
            //}
            //listOne.AddRange(listTwo);
            //foreach (int item in listOne)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.ReadKey();


            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            //Console.WriteLine("请输入一个字符串");
            //string str = Console.ReadLine();
            //char[] chs = new char[str.Length];
            //int i = 0;
            //foreach (char item in str)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (char item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();


            //统计 Welcome to china中每个字符出现的次数 不考虑大小写
            string str = "Welcome to china";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ')
                {
                    continue;
                }
                if (!dic.ContainsKey(str[i]))
                {
                    dic[str[i]] = 1;
                }
                else
                {
                    dic[str[i]]++;
                }
            }
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("{0}-----------{1}", kv.Key, kv.Value);
            }
            Console.ReadKey();

        }
    }
}
