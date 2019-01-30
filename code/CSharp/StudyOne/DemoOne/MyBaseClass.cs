using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    /// <summary>
    /// 基类示例
    /// </summary>
    public class MyBaseClass
    {
        #region 字段
        private string field1 = "MyBaseClass Field1";
        private readonly int intVal = 5;
        #endregion

        #region 属性
        /// <summary>
        /// 字符串
        /// </summary>
        public string Field1 { get => field1; set => field1 = value; }
        /// <summary>
        /// 数字
        /// </summary>
        internal int Num { get; set; } = 10;
        /// <summary>
        /// 标记要覆写的属性
        /// </summary>
        internal virtual int IntVal { get => intVal; }
        #endregion


        #region 构造函数
        public MyBaseClass()
        {
        }
        public MyBaseClass(string field1) : this(20)
        {
            Field1 = field1;
        }

        public MyBaseClass(int num) => Num = num;
        public MyBaseClass(string field1, int num) : this(num)
        {
            Field1 = field1;
        }
        #endregion



        /// <summary>
        /// 基类方法
        /// </summary>
        /// <param name="value"></param>
        public void Method1(string value)
        {
            Console.WriteLine("MyBaseClass.Method1:{0}", value);
        }
        /// <summary>
        /// 虚方法
        /// </summary>
        internal virtual void Print() => Console.WriteLine("This is the base class.");
    }
}
