using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07练习1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1考试成绩等级
            //编写一段程序，运行时向用户提问“你考了多少分？（0~100）”，接受输入后判断其等级并显示出来。判断依据如下：等级={优 （90~100分）；良 （80~89分）；中 （60~69分）；差 （0~59分）；}
            //while (true)
            //{
            //    Console.WriteLine("你考了多少分");
            //    double result = Convert.ToDouble(Console.ReadLine());
            //    char ch = Result(result);
            //    Console.WriteLine("成绩等级为{0}", ch);
            //}
            #endregion

            #region 2）九九乘法表
            ////输出九九乘法表
            //Console.WriteLine("九九乘法表");
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey(); 
            #endregion

            #region 3)一行n个输出数字
            ////定义长度50的数组,随机给数组赋值,并可以让用户输入一个数字n,按一行n个数输出数组 
            //Console.WriteLine("请输入不大于50的数字");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Random r = new Random();
            //int[] array = new int[50];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0, 100);
            //}
            ////foreach (int item in array)
            ////{
            ////    Console.Write(item+"\t");
            ////    //if (50%n==0)
            ////    //{
            ////    //    Console.WriteLine();
            ////    //}
            ////}
            //for (int i = 0; i < 50; i++)
            //{
            //    if ((i + 1) % n == 0)
            //    {
            //        Console.WriteLine(array[i]);
            //    }
            //    else
            //    {
            //        Console.Write(array[i] + "\t");
            //    }
            //}
            //Console.ReadKey(); 
            #endregion

            #region 4）大写转换为小写
            ////编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范  骆驼命名)
            //Console.WriteLine("请输入第一个字母大写字符串");
            //string str = Console.ReadLine();
            //string strNew = DaXie(str);
            //Console.WriteLine(strNew);
            //Console.ReadKey(); 
            #endregion

            #region 6）交换变量
            //6.声明两个变量：int n1 = 10, n2 = 20;要求将两个变量交换，最后输出n1为20,n2为10。扩展（*）：不使用第三个变量如何交换？
            //int n1 = 10, n2 = 20;
            //Exchange(ref n1, ref n2);
            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey(); 
            #endregion

            #region 8)字符串个数
            //8.请用户输入一个字符串，计算字符串中的字符个数，并输出。
            //string str = "abcd cdefg";
            //Console.WriteLine(str);
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //dic = Test(str);
            //foreach (KeyValuePair<char, int> kv in dic)
            //{
            //    Console.WriteLine("{0}字符个数为{1}", kv.Key, kv.Value);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 9)求最大值
            //用方法来实现：计算两个数的最大值。思考：方法的参数？返回值？扩展（*）：计算任意多个数间的最大值（提示：params）
            //int[] nums = { 1, 2, 4, 7, 3, 6 };
            //int max = GetMax(nums);
            //Console.WriteLine(max);
            //Console.ReadKey(); 
            #endregion

            #region 10）求和
            //用方法来实现：计算1-100之间的所有整数的和
            //int num = GetAdd();
            //Console.WriteLine(num);
            //Console.ReadKey(); 
            #endregion

            #region 12)质数
            //用方法来实现：判断一个给定的整数是否为“质数”
            //int num = 137;
            //if (IsPrime(num))
            //{
            //    Console.WriteLine("质数");
            //}
            //else
            //{
            //    Console.WriteLine("不是质数");
            //}
            //Console.ReadKey(); 
            #endregion

            #region 13）上题1-100
            ////用方法来实现：计算1-100之间的所有质数（素数）的和
            //int num = GetAdd();
            //Console.WriteLine(num);
            //Console.ReadKey(); 
            #endregion

            #region 15)最长字符串
            //用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串
            //string[] strs = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string str = GetMaxStr(strs);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "adss";
            //Console.WriteLine(str);
            //str = "sflfaji";
            //Console.WriteLine(str);
            //Console.ReadKey(); 
            #endregion

            #region 16)整型数组平均值
            //用方法来实现：请计算出一个整型数组的平均值。{ 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 }。要求：计算结果如果有小数，则显示小数点后两位（四舍五入）
            //int[] nums = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            //double num = GetMean(nums);
            //Console.WriteLine("平均值为{0:0.00}", num);
            //Console.ReadKey(); 
            #endregion

            #region 17)冒泡排序法
            //请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序
            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //GetSort(ref nums);
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 18)随机成绩平均值
            //为教师编写一个程序，该程序使用一个数组存储30个学生的考试成绩，并给各个数组元素指定一个1-100的随机值，然后计算平均成绩
            //int[] nums = new int[30];
            //Cun(ref nums);
            //foreach (var item in nums)
            //{
            //    Console.Write(item + " ");
            //}
            //double mean = GetMean(nums);
            //Console.WriteLine(" 平均值" + mean);
            //Console.ReadKey(); 
            #endregion

            #region 19)找包含字符串
            //有如下字符串：【"患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”"】。需求：请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置
            //string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            //int n = 0, i = 0;
            //while (n != -1)
            //{
            //    n = str.IndexOf("咳嗽", n + 1);
            //    if (n == -1)
            //    {
            //        break;
            //    }
            //    i++;
            //    Console.WriteLine("第{0}次出现位置{1}", i, n);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 20)字符串方法
            //将字符串"  hello      world,你  好 世界   !    "两端空格去掉，并且将其中的所有其他空格都替换成一个空格，输出结果为："hello world,你 好 世界 !"
            //string str = "  hello      world,你  好 世界   !    ";
            //Console.WriteLine(str);
            //str = str.Trim();
            //Console.WriteLine(str);
            //string[] sNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //str = string.Join(" ", sNew);
            //Console.ReadKey(); 
            #endregion

            #region 21)录入学生姓名22
            //制作一个控制台小程序。要求：用户可以在控制台录入每个学生的姓名，当用户输入quit（不区分大小写）时，程序停止接受用户的输入，并且显示出用户输入的学生的个数，以及每个学生的姓名
            //List<string> list = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("请输入姓名");
            //    string name = Console.ReadLine();
            //    if (string.Equals(name, "quit", StringComparison.OrdinalIgnoreCase))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        list.Add(name);
            //    }
            //}
            //Console.WriteLine("您一共录入了：{0}个学生，姓名分别为：", list.Count);
            //int num = 0;
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //    if (item[0] == '王')
            //    {
            //        num++;
            //    }
            //}
            //Console.WriteLine("姓王的同学个数为：" + num);
            //Console.ReadKey(); 
            #endregion

            #region 23)反转输出
            //请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法
            //string[] str = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //string[] s = new string[str.Length];
            //for (int i = 0; i < (str.Length + 1) / 2; i++)
            //{
            //    string temp = str[i];
            //    str[i] = str[str.Length - 1 - i];
            //    str[str.Length - 1 - i] = temp;
            //}
            //foreach (var item in str)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 24)重写父类方法
            //创建一个Person类，属性：姓名、性别、年龄；方法：SayHi() 。再创建一个Employee类继承Person类，扩展属性Salary,重写SayHi方法
            //Person p = new Employee();
            //p.SayHi();
            //Console.ReadKey(); 
            #endregion

        }
        internal static void Cun(ref int[] nums)
        {
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1, 101);
            }
        }
        /// <summary>
        /// 冒泡法正序排序
        /// </summary>
        /// <param name="nums"></param>
        internal static void GetSort(ref int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-i-1; j++)
                {
                    if (nums[j]>nums[j+1])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        internal static double GetMean(int[] nums)
        {
            double num = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                num += nums[i];
            }
            return num /= nums.Length;
        }
        /// <summary>
        /// 最长字符串
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        internal static string GetMaxStr(string[] strs)
        {
            string str = strs[0];
            for (int i = 0; i < strs.Length; i++)
            {
                if (str.Length<strs[i].Length)
                {
                    str = strs[i];
                }
            }
            return str;
        }
        /// <summary>
        /// 判断质数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        internal static bool IsPrime(int num)
        {
            bool b = true;
            for (int i = 2; i < num; i++)
            {
                if (num%i==0)
                {
                    b = false;
                    break;
                }
            }
            return b;
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <returns></returns>
        internal static int GetAdd()
        {
            int num = 0;
            for (int i = 2; i <= 100; i++)
            {
                if (IsPrime(i))
                {
                    num += i;
                }
            }
            return num;
        }
        internal static int GetMax(int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
            }
            return max;
        }
        internal static Dictionary<char, int> Test(string str)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    if (dic.Keys.Contains(str[i]))
                    {
                        dic[str[i]]++;
                    }
                    else
                    {
                        dic.Add(str[i], 1);
                    }
                }
            }
            return dic;
        }
        /// <summary>
        /// 两值交换
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void Exchange(ref int n1, ref int n2)
        {
            n1 = n1 - n2;
            n2 = n1 + n2;
            n1 = n2 - n1;
        }

        public static string DaXie(string str)
        {
            string strNew = str.Substring(0, 1).ToLower() + str.Substring(1);
            return strNew;
        }

        public static char Result(double result)
        {
            char ch;
            if (result > 100 || result < 0)
            {
                result = 0;
            }
            if (result >= 90)
            {
                ch = '优';
            }
            else if (result >= 80)
            {
                ch = '良';
            }
            else if (result >= 60)
            {
                ch = '中';
            }
            else
            {
                ch = '差';
            }
            return ch;
        }
    }
}
