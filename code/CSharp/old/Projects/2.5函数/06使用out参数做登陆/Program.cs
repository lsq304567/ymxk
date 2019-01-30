using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06使用out参数做登陆
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;
            while(b==false)
            {
                Console.WriteLine("请输入用户名");
                string name = Console.ReadLine();
                Console.WriteLine("请输入密码");
                string pwd = Console.ReadLine();
                string msg;//多与返回登陆信息
                b = IsLogin(name, pwd, out msg);//返回登陆结果
                Console.WriteLine(b);
                Console.WriteLine(msg);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 判断登陆是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">密码</param>
        /// <param name="msg">多与返回登陆信息</param>
        /// <returns>返回登陆结果</returns>
        public static bool IsLogin(string name, string pwd, out string msg)
        {
            if (name == "admin" && pwd == "888888")
            {
                msg = "登陆成功";
                return true;
            }
            else if (name == "admin")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd == "888888")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }
    }
}
