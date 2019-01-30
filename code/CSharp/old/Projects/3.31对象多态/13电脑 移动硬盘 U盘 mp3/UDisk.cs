using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13电脑_移动硬盘_U盘_mp3
{
    /// <summary>
    /// U盘
    /// </summary>
    public class UDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }
}
