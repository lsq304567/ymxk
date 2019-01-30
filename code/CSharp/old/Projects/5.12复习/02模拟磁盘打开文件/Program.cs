using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02模拟磁盘打开文件
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开的磁盘");
            string path = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件名");
            string fileName = Console.ReadLine();
            //文件的全路径：path+fileName
            FileFather ff = GetFile(fileName,path+fileName);
            ff.OpenFile();
            Console.ReadKey();
        }
        public static FileFather GetFile(string fileName,string fullName)
        {
            FileFather ff = null;
            string extension = Path.GetExtension(fileName);
            switch (extension)
            {
                case ".txt":ff = new TxtPath(fullName);
                    break;
                case ".jpg":ff = new JpgPath(fullName);
                    break;
                case ".avi":ff = new AviPath(fullName);
                    break;
            }
            return ff;
        }
    }
}
