using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    /// <summary>
    /// 派生类示例
    /// </summary>
    internal class MyDerivedClass : MyBaseClass
    {

        #region 字段
        private readonly int intVal = 10;
        #endregion

        #region 属性
        /// <summary>
        /// 屏蔽基类成员
        /// </summary>
        public new string Field1 { get; set; } = "MyDerivedClass Feild1";
        /// <summary>
        /// 覆写属性
        /// </summary>
        internal override int IntVal => intVal;
        #endregion

        public MyDerivedClass() : base()
        {
        }

        public MyDerivedClass(string field1) : base(field1) => Field1 = field1;

        /// <summary>
        /// 屏蔽基类方法
        /// </summary>
        /// <param name="value"></param>
        public new void Method1(string value) => Console.WriteLine("MyDerivedClass.Method1:{0}", value);

        /// <summary>
        /// 访问基类成员
        /// </summary>
        internal void PrintField1()
        {
            Console.WriteLine(Field1);
            Console.WriteLine(base.Field1);
        }

        /// <summary>
        /// 重写
        /// </summary>
        internal override void Print()
        {
            Console.WriteLine("This is the derived class.");
        }

    }
}
