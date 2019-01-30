using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02模拟磁盘打开文件
{
    class TxtPath : FileFather
    {
        public TxtPath(string fullName) : base(fullName)
        {
        }
        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fullName);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }
}
