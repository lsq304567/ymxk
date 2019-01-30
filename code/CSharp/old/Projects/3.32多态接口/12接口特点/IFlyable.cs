using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口特点
{
    public interface IFlyable
    {
        //不允许有访问修饰符  创建为默认公开
        //方法 自动属性
        void Fly();
    }
}
