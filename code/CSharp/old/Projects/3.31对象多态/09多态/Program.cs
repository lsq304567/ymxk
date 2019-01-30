using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //概念：让一个对象能够表现出多种状态（类型）
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李雷");
            Japanese j1 = new Japanese("树下君");
            Japanese j2 = new Japanese("井边子");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金贤秀");
            American a1 = new American("科比布莱恩特");
            American a2 = new American("奥尼尔");
            Person[] pers = { cn1, cn2, j1, j2, k1, k2, a1, a2 };
            for (int i = 0; i < pers.Length; i++)
            {
                pers[i].SayHellow();
            }
            Console.ReadKey();


        }
    }
}
