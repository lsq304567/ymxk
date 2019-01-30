using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13电脑_移动硬盘_U盘_mp3
{
    /// <summary>
    /// Mp3
    /// </summary>
    public class Mp3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("Mp3自己可以播放音乐");
        }
    }
}
