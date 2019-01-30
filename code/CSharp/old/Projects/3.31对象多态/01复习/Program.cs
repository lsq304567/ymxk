using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Student();
            ////if (p is Student)
            ////{
            ////    ((Student)p).StudentSayHellow();
            ////}
            ////else
            ////{
            ////    Console.WriteLine("转换失败");
            ////}
            //Student ss = p as Student;
            //ss.StudentSayHellow();
            //Console.ReadKey();

            //Hashtable ht = new Hashtable();
            //ht.Add(1, 3.14);
            //ht.Add(2, "张三");
            //ht.Add(true, 50000m);
            //bool b=ht.ContainsKey(true);
            //foreach (var item in ht.Keys)
            //{
            //    Console.WriteLine("{0}----------{1}", item, ht[item]);
            //}
            //Console.ReadKey();

            //Path.

            //byte[] buffer= File.ReadAllBytes(@"C:\Users\PC\Desktop\new.txt");
            //string str=Encoding.Default.GetString(buffer);
            //Console.WriteLine(str);
            //Console.ReadKey();

            string str = "今天天气好晴朗，处处好风光";
            byte[] buffer = Encoding.Default.GetBytes(str);
            File.WriteAllBytes(@"C:\Users\PC\Desktop\new.txt", buffer);
            Console.WriteLine("写入成功");
            Console.ReadKey();

        }
    }
}
