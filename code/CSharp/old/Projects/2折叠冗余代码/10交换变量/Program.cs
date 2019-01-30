using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10交换变量
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10, number2 = 20;
            int temp;
            //temp = number1;
            //number1 = number2;
            //number2 = temp;
            
            //交换两个int类型变量，要求不使用第三方变量
            //这个方式对其他整型都适应
            number1 = number1 - number2;//number1=-10,number2=20
            number2 = number1 + number2;//number1=-10,number2=10
            number1 = number2 - number1;
            Console.WriteLine("交换后，n1的值为{0}，n2的值为{1}", number1, number2);
            Console.ReadKey();

        }      
    }
}
