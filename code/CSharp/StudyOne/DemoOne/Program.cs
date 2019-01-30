using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOne
{
    class Program
    {
        private static MyClass a1;
        private static int a2 = 10;
        private static int first = 5, second = 6, third = 7;
        private static double volume;
        private static int r0;
        private static int r1;
        /// <summary>
        /// 派生类实例
        /// </summary>
        private static MyDerivedClass myDerived;
        /// <summary>
        /// 基类实例
        /// </summary>
        private static MyBaseClass myBase;
        /// <summary>
        /// 二级派生类实例
        /// </summary>
        private static SecondDerived secondDerived;
        private static MyBaseClass myBase2;
        /// <summary>
        /// 抽象类实例
        /// </summary>
        private static DerivedClass derived;
        /// <summary>
        /// 主函数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region CSharp概述
            //多重标记和值
            System.Console.WriteLine("多重标记和值1:{1},0:{0},1:{1}", 3, 6);
            //格式化数字字符串  字符的最少数量
            Console.WriteLine("货币:|{0,9:c}|", 500);//右对齐
            Console.WriteLine("货币:|{0,-9:c}|", 500);//左对齐 
            Console.WriteLine();
            #endregion

            #region 初始值
            a1 = new MyClass();
            Console.WriteLine("初始值");
            Console.WriteLine(string.Format("f1.Val:{0},f2:{1}", a1.Val, a2));
            #endregion

            #region 值参数和引用参数
            Console.WriteLine("值传递");
            MyMethod(a1, a2);
            Console.WriteLine("f1.Val:{0},f2:{1}", a1.Val, a2);
            Console.WriteLine("引用传递");
            MyMethod(ref a1, ref a2);
            Console.WriteLine("f1.Val:{0},f2:{1}", a1.Val, a2);
            Console.WriteLine("引用类型作为值参数");
            a1.Val = 20;
            Console.WriteLine("{0}形参初始", a1.Val);
            RefAsParameter(a1);
            Console.WriteLine("{0}实参", a1.Val);
            Console.WriteLine("引用类型作为引用参数");
            a1.Val = 20;
            Console.WriteLine("{0}形参初始", a1.Val);
            RefAsParameter(ref a1);
            Console.WriteLine("{0}实参", a1.Val);
            #endregion

            #region 输出参数
            Console.WriteLine("输出参数");
            a1 = null;
            a2 = 0;
            if (a1 == null)
            {
                Console.WriteLine("f1.Val:null{0},f2:{1}", DBNull.Value, a2);
            }
            MyMethod(out a1, out a2, 0);
            Console.WriteLine("f1.Val:{0},f2:{1}", a1.Val, a2);
            #endregion

            #region 参数数组
            Console.WriteLine("参数数组");
            a1.ListInts(first, second, third);
            Console.WriteLine("{0},{1},{2}", first, second, third);
            #endregion

            #region 命名参数
            Console.WriteLine("命名参数");
            volume = a1.GetCylinderVolume(3.0, 4.0);
            Console.WriteLine(volume);
            volume = a1.GetCylinderVolume(height: 4.0, radius: 3.0);
            Console.WriteLine(volume);
            #endregion

            #region 可选参数
            Console.WriteLine("可选参数");
            r0 = a1.Calc(5, 6);
            r1 = a1.Calc(5);
            Console.WriteLine("{0},{1}", r0, r1);
            #endregion

            #region 递归
            Console.WriteLine("递归");
            Console.WriteLine("5的阶乘：{0}", a1.Factorial(5));
            #endregion 

            #region 索引器
            Console.WriteLine("索引器");
            a1[0] = 30;
            Console.WriteLine(a1[0]);
            #endregion

            #region 基类
            Console.WriteLine("屏蔽基类成员");
            myDerived = new MyDerivedClass();
            myDerived.Method1(myDerived.Field1);
            Console.WriteLine("访问基类成员");
            myDerived.PrintField1();
            Console.WriteLine("使用基类的引用");
            myBase = myDerived as MyBaseClass;
            myBase.Method1(myBase.Field1);
            #endregion

            #region 覆写
            Console.WriteLine("覆写虚方法");
            myDerived.Print();
            myBase.Print();
            Console.WriteLine("new声明要覆写的方法");
            secondDerived = new SecondDerived();
            myBase2 = secondDerived as MyBaseClass;
            secondDerived.Print();
            myBase2.Print();
            Console.WriteLine("覆写属性");
            Console.WriteLine(myDerived.IntVal);
            Console.WriteLine(myBase.IntVal);
            #endregion

            #region 构造函数
            myBase = new MyBaseClass("base 构造函数测试", 12);
            Console.WriteLine("{0},{1}", myBase.Field1, myBase.Num);

            myBase = new MyBaseClass("base 构造函数默认值 测试");
            Console.WriteLine("{0},{1}", myBase.Field1, myBase.Num);

            myDerived = new MyDerivedClass("derived 构造函数测试");
            Console.WriteLine(myDerived.Field1);
            #endregion

            Console.WriteLine("抽象类");
            derived = new DerivedClass();
            derived.IdentifyBase();
            derived.IdentifyDerived();
            

            Console.ReadKey();
        }

        #region 值参数和引用参数
        /// <summary>
        /// 值参数 add5
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        static void MyMethod(MyClass f1, int f2)
        {
            //形参是一个新的栈
            f1.Val = f1.Val + 5;//实参的引用地址复制到形参
            f2 = f2 + 5;//值被复制
            Console.WriteLine("f1.Val:{0},f2:{1}", f1.Val, f2);
        }
        /// <summary>
        /// 引用参数    add5
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        static void MyMethod(ref MyClass f1, ref int f2)
        {
            //形参同样指向实参的栈
            f1.Val = f1.Val + 5;//指向同一个栈
            f2 = f2 + 5;//
            Console.WriteLine("f1.Val:{0},f2:{1}", f1.Val, f2);
        }
        /// <summary>
        /// 引用类型作为值参数
        /// </summary>
        /// <param name="f1"></param>
        static void RefAsParameter(MyClass f1)
        {
            f1.Val = 50;
            Console.WriteLine("{0}形参", f1.Val);
            f1 = new MyClass();
            Console.WriteLine("{0}形参", f1.Val);
        }
        /// <summary>
        /// 引用类型作为引用参数
        /// </summary>
        /// <param name="f1"></param>
        static void RefAsParameter(ref MyClass f1)
        {
            f1.Val = 50;
            Console.WriteLine("{0}形参", f1.Val);
            f1 = new MyClass();
            Console.WriteLine("{0}形参", f1.Val);
        }
        #endregion

        #region 输出参数
        /// <summary>
        /// 输出参数
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <param name="f3">防止与ref重载冲突</param>
        static void MyMethod(out MyClass f1, out int f2, int f3)
        {
            f1 = new MyClass();
            f1.Val = 25;
            f2 = 15;
        }
        #endregion
    }
}
