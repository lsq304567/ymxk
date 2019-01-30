using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = File.ReadAllLines(@"C:\Users\PC\Desktop\1.txt",Encoding.Default);
            for (int i = 0; i < str.Length; i++)
            {
                string[] strNew= str[i].Split(new char[] { '|'}, StringSplitOptions.RemoveEmptyEntries);
                int salary = Convert.ToInt32(strNew[1]) * 2;
                str[i] = strNew[0] +"|"+ salary.ToString();
            }
            File.WriteAllLines(@"C:\Users\PC\Desktop\1.txt", str);
            Console.WriteLine("ok");
            Console.ReadKey();


        }
    }
}
