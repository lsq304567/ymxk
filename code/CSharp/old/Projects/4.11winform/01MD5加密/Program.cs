using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _01MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");
            //3244185981728979115075721453575112
            //202cb962ac5975b964b7152d234b70
            //202cb962ac59075b964b07152d234b70
            Console.WriteLine(s);
            Console.ReadKey();


        }
        public static string GetMD5(string str)
        {
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            byte[] buffer = Encoding.Default.GetBytes(str);
            //返回一个加密好的数组
            byte[] MD5buffer= md5.ComputeHash(buffer);
            //将字节数组转换为字符串
            //return Encoding.Default.GetString(MD5buffer);
            string strNew = "";
            for (int i = 0; i < MD5buffer.Length; i++)
            {
                strNew += MD5buffer[i].ToString("x2");
            }
            return strNew;
        }
    }
}
