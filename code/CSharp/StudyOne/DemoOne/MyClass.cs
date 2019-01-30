using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    /// <summary>
    /// 类示例  隐式继承Object 别名object
    /// 成员不可比类有更高的可访问性
    /// </summary>
    public class MyClass : object
    {
        #region 字段
        /// <summary>
        /// const常量  声明时必须赋值 必须在字段声明中初始化
        /// </summary>
        const double pi = 3.1415926;
        /// <summary>
        /// readonly常量  字段声明和构造函数中赋值
        /// </summary>
        readonly int numberOfSides;
        private int val = 20;
        private string name;
        #endregion

        #region 属性
        /// <summary>
        /// 属性  限制
        /// </summary>
        public int Val
        {
            get => val; set
            {
                val = value > 100 ? 100 : value;
            }
        }
        /// <summary>
        /// 不同访问级别的访问器
        /// </summary>
        public string Name { get => name; private set => name = value; }
        #endregion

        #region 构造函数
        public MyClass() { }
        public MyClass(int val) => this.Val = val;
        public MyClass(int val, int numberOfSides)
        {
            this.Val = val;
            this.numberOfSides = numberOfSides;
        }
        public MyClass(string name) => this.Name = name;
        #endregion

        #region 索引器
        /// <summary>
        /// 索引器  可重载
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0:
                        this.Val = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("index");
                }
            }
            get
            {
                switch (index)
                {
                    case 0: return Val;
                    default:
                        throw new ArgumentOutOfRangeException("index");
                }
            }
        }
        #endregion

        #region 类长度

        #endregion

        #region 方法
        #region 参数数组
        /// <summary>
        /// 参数数组
        /// </summary>
        /// <param name="inVals"></param>
        public void ListInts(params int[] inVals)
        {
            if ((inVals != null) && (inVals.Length != 0))
            {
                for (int i = 0; i < inVals.Length; i++)
                {
                    inVals[i] = inVals[i] * 10;
                    Console.WriteLine("{0}", inVals[i]);
                }
            }
        }
        #endregion

        #region 命名参数
        /// <summary>
        /// 命名参数    获得圆柱体积  内部的
        /// </summary>
        /// <param name="radius">半径</param>
        /// <param name="height">高</param>
        /// <returns></returns>
        internal double GetCylinderVolume(double radius, double height)
        {
            return pi * radius * radius * height;
        }
        #endregion

        #region 可选参数
        /// <summary>
        /// 可选参数
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        internal int Calc(int a, int b = 3)
        {
            return a + b;
        }
        #endregion

        #region 递归
        /// <summary>
        /// 递归  计算阶乘
        /// </summary>
        /// <param name="inValue"></param>
        /// <returns></returns>
        internal int Factorial(int inValue)
        {
            if (inValue <= 1)
            {
                return inValue;
            }
            else
            {
                return inValue * Factorial(inValue - 1);
            }
        }
        #endregion

        #region 重写运算符

        #endregion

        #endregion

    }
}
