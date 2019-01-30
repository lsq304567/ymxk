using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态来求矩形的面积和周长以及圆形的面积和周长
            Shape shape = new Circle(5);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine("这个圆的面积是{0}，周长是{1}", area, perimeter);
            Console.ReadKey();


        }
    }
}
