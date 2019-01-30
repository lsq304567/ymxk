using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace _05序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 23;
            //p.Gender = '男';
            //using (FileStream fsWrite = new FileStream(@"C:\Users\PC\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    //开始序列化对象
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();


            //接收对方发送过来的二进制，反序列化对象
            Person p = new Person();
            using(FileStream fsRead=new FileStream(@"C:\Users\PC\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();

        }
    }
}
