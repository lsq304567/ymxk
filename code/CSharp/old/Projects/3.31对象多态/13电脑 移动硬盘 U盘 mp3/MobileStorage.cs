using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13电脑_移动硬盘_U盘_mp3
{
    /// <summary>
    /// 存储设备
    /// </summary>
    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
}
