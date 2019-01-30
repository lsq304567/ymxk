using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03这个人上辈子是干嘛的
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            while (true)
            {
                int rNumber = r.Next(1, 7);
                Console.WriteLine("请输入一个名字");
                string name = Console.ReadLine();
                if (name=="李国超")
                {
                    rNumber = 6;
                }
                switch (rNumber)
                {
                    case 1:
                        Console.WriteLine("{0}上辈子是吃翔的", name);
                        break;
                    case 2:
                        Console.WriteLine("{0}上辈子是拉翔的", name);
                        break;
                    case 3:
                        Console.WriteLine("{0}上辈子是一坨翔", name);
                        break;
                    case 4:
                        Console.WriteLine("{0}上辈子是个大汉奸", name);
                        break;
                    case 5:
                        Console.WriteLine("{0}上辈子是拉皮条的", name);
                        break;
                    default:
                        Console.WriteLine("{0}上辈子是救苦救难的大菩萨", name);
                        break;
                }
                Console.ReadKey();
            }

        }
    }
}
