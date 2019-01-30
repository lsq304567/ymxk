using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子嘎嘎叫  木头鸭子吱吱叫  橡皮鸭子唧唧叫
            RealDuck rd = new RealDuck();
            MuDuck md = new MuDuck();
            XPDuck xd = new XPDuck();
            RealDuck[] ducks = { rd, md, xd };
            for (int i = 0; i < ducks.Length; i++)
            {
                ducks[i].Bark();
            }
            Console.ReadKey();


        }
    }
}
