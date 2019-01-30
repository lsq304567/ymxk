using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想要的笔记本的品牌");
            string brand = Console.ReadLine();
            NotoBook nb = GetNotoBook(brand);
            nb.SayHellow();
            Console.ReadKey();

        }
        /// <summary>
        /// 简单工厂的核心  根据用户的输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NotoBook GetNotoBook(string brand)
        {
            NotoBook nb = null;
            switch (brand)
            {
                case "lenovo":nb = new Lenovo();
                    break;
                case "IBM":nb = new IBM();
                    break;
                case "Acer":nb = new Acer();
                    break;
                case "Dell":nb = new Dell();
                    break;
                default:
                    break;
            }
            return nb;
        }
    }
}
