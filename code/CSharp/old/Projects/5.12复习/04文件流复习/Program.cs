using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04文件流复习
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fsRead = new FileStream(@"C:\Users\PC\Desktop\1、单例模式.avi", FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                while (true)
                {
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    string s = Encoding.Default.GetString(buffer, 0, r);
                    Console.WriteLine(s);
                }
            }


        }
    }
}
