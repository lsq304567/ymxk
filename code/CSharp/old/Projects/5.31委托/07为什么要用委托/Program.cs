using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07为什么要用委托
{
    class Program
    {
        public delegate string DelProStr(string name);
        static void Main(string[] args)
        {
            //三个需求
            //1将字符串数组转换为大写
            //2转换为小写
            //3每个元素两边加上双引号
            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            //ProStrToUpper(names);
            ProStr(names, delegate(string name) {
                return name.ToUpper();
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();

        }
        public static void ProStr(string[] name,DelProStr del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }
        //public static string StrUpper(string name)
        //{
        //    return name.ToUpper();
        //}
        //public static string StrLower(string name)
        //{
        //    return name.ToLower();
        //}
        //public static string StrSYH(string name)
        //{
        //    return "\"" + name + "\"";
        //}

        //public static void ProStrToUpper(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToUpper();
        //    }
        //}
        //public static void ProStrToLower(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToLower();
        //    }
        //}
        //public static void ProStrSYH(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = "\"" + names[i] + "\"";
        //    }
        //}


    }
}
