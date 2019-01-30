using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我是记者  我的爱好是偷拍  我的年龄是34岁  我是一个男狗仔
            //司机：我是舒马赫  我的年龄是43岁  我是男人  我的驾龄是21年
            //程序员：我是孙权  我的年龄是23岁  我是男生  我的工作年限是3年
            Reporter rep = new Reporter("记者", 34, '男', "偷拍");
            rep.ReporterSayHellow();
            Programmer pro = new Programmer("孙权", 23, '男', 3);
            pro.ProgrammerSayHellow();
            Console.ReadKey();

        }
    }
}
