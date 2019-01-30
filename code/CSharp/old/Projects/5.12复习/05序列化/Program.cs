using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _05序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "张三";
            p.Age = 25;
            p.Gender = "男";
            //using (FileStream fsWrite = new FileStream(@"C:\Users\PC\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write)
            //{
            //    //BinaryFormatter bf=new BinaryFormatter();
            //    //bf.Serialize(fsWrite, p);
            

            //}


        }
    }
}
