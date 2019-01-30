using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FileStrem
{
    class Program
    {
        static void Main(string[] args)
        {
            ////使用FileStream来读取数据
            FileStream fsRead = new FileStream(@"C:\Users\PC\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            //3.8M   5M
            //返回的是实际读取到的有效数字
            int r = fsRead.Read(buffer, 0, buffer.Length);
            //将字节数组按指定的元素编码格式进行解码
            string s = Encoding.Default.GetString(buffer, 0, r);
            //关闭流
            fsRead.Close();
            //释放流所占用的资源
            fsRead.Dispose();
            Console.WriteLine(s);
            Console.ReadKey();


            //使用FileStream来写入数据
            //using (FileStream fsWrite = new FileStream(@"C:\Users\PC\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "看我有没有你覆盖掉";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入OK");
            //Console.ReadKey();


        }
    }
}
