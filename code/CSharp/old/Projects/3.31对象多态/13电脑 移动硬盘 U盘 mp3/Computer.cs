using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13电脑_移动硬盘_U盘_mp3
{
    /// <summary>
    /// 电脑
    /// </summary>
    public class Computer
    {
        private MobileStorage ms;
        public MobileStorage Ms { get => ms; set => ms = value; }

        public void CpuRead() => Ms.Read();
        public void CpuWrite() => Ms.Write();
    }
}
