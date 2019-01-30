using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Person[] pers = new Person[10];
            for (int i = 0; i < pers.Length; i++)
            {
                int rNumber = r.Next(1, 7);
                switch (rNumber)
                {
                    case 1:
                        pers[i] = new Student();
                        break;
                    case 2:
                        pers[i] = new Teacher();
                        break;
                    case 3:
                        pers[i] = new ShuaiGe();
                        break;
                    case 4:
                        pers[i] = new MeiNv();
                        break;
                    case 5:
                        pers[i] = new YeShou();
                        break;
                    default:
                        pers[i] = new Person();
                        break;
                }
            }
            for (int i = 0; i < pers.Length; i++)
            {
                if (pers[i] is Student)
                {
                    ((Student)pers[i]).StudentSayHi();
                }
                else if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TeacherSayHi();
                }
                else if (pers[i] is ShuaiGe)
                {
                    ((ShuaiGe)pers[i]).ShuaiGeSayHi();
                }
                else if (pers[i] is MeiNv)
                {
                    ((MeiNv)pers[i]).MeiMvSayHi();
                }
                else if (pers[i] is YeShou)
                {
                    ((YeShou)pers[i]).YeShouSayHi();
                }
                else
                {
                    pers[i].PersonSayHi();
                }
            }
            Console.ReadKey();
        }
    }
}
