using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02模拟磁盘打开文件
{
    public abstract class FileFather
    {
        public FileFather(string fullName)
        {
            this.fullName = fullName;
        }
        public string fullName
        {
            get;
            set;
        }
        public abstract void OpenFile();
    }
}
