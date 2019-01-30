using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03结构
{
    public struct Person
    {
        public string _name;//字段
        public int _age;
        public Gender _gender;
    }
    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 结构学习
            //xx大学管理系统
            //姓名 年龄 性别 
            Person zsName;
            zsName._name = "张三";
            zsName._age = 18;
            zsName._gender = Gender.男;
            Person lsName;
            lsName._name = "李四";
            lsName._age = 14;
            lsName._gender = Gender.女;
            Console.WriteLine(zsName._name);
            Console.WriteLine(lsName._name);
            Console.ReadKey();
            #endregion
        }
    }
}
