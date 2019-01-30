using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07使用文件流实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            //先将要复制的多媒体文件读取出来，然后在写入指定的位置
            string source = @"C:\Users\PC\Desktop\8、使用FileStream实现多媒体文件的复制.avi";
            string target = @"C:\Users\PC\Desktop\new.avi";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();


        }
        public static void CopyFile(string source, string target)
        {
            //1创建一个负责读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                //创建负责写入的流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1027 * 1024 * 5];
                    while (true)
                    {
                        //返回本次实际读取到的字节
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r==0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                }//写入
            }//读取
        }//方法括号


    }
}
