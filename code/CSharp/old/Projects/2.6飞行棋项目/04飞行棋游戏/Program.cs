using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04飞行棋游戏
{
    class Program
    {
        //静态字段模拟全局变量
        static int[] Maps = new int[100];
        //声明一个静态字段存储玩家A和B的坐标
        static int[] PlayerPos = new int[2];
        //声明字符串数组来存储玩家姓名
        static string[] PlayerNames = new string[2];
        //两个玩家的标记
        static bool[] Flags = new bool[2];//Flags[0]默认是false  Flags[1]默认也是false
        //画地图时需求的字符串
        static string str = null;
        static void Main(string[] args)
        {
            GameShow();
            #region 输入玩家姓名
            Console.WriteLine("请输入玩家A的姓名");
            PlayerNames[0] = Console.ReadLine();
            while (PlayerNames[0]=="")
            {
                Console.WriteLine("玩家A的姓名不能为空，请重新输入");
                PlayerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B的姓名");
            PlayerNames[1] = Console.ReadLine();
            while (PlayerNames[1]==""||PlayerNames[0]==PlayerNames[1])
            {
                if (PlayerNames[1] == "")
                {
                    Console.WriteLine("玩家B的姓名不能为空，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("玩家B的姓名不能与玩家A的姓名相同，请重新输入");
                    PlayerNames[1] = Console.ReadLine();
                }
            }
            #endregion
            #region 游戏准备部分
            Console.Clear();//清屏
            GameShow();
            Console.WriteLine("{0}的士兵用A表示", PlayerNames[0]);
            Console.WriteLine("{0}的士兵用B表示", PlayerNames[1]);
            InitailMap();
            DrawMap();
            #endregion
            #region 当玩家A跟玩家B没有一个人在终点的时候 两个玩家不停的去玩游戏
            while (true)
            {
                if (Flags[0]==false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flags[0] = false;
                }
                if (PlayerPos[0]==99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}",PlayerNames[0],PlayerNames[1]);
                    break;
                }
                if (Flags[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flags[1] = false;
                }
                if (PlayerPos[1]==99)
                {
                    Console.WriteLine("玩家{0}无耻的赢了玩家{1}",PlayerNames[1],PlayerNames[0]);
                }
            }
            #endregion
            Win();
            Console.ReadKey();
        }
        /// <summary>
        /// 游戏头
        /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****夜明星空版飞行棋项目****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************************");
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitailMap()
        {
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            int[] pause = { 9, 27, 60, 93, 2,  4, 7, 8 };//暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }
        /// <summary>
        /// 画地图
        /// </summary>
        public static void  DrawMap()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                DrawStringMap(i);
                Console.Write(str);
                #region 画地图中抽象出来的方法
                //if (PlayerPos[0]==PlayerPos[1]&&PlayerPos[1]==i)
                //{
                //    Console.Write("<>");
                //}
                //else if (PlayerPos[0]==i)
                //{
                //    Console.Write("Ａ");
                //}
                //else if (PlayerPos[1]==i)
                //{
                //    Console.Write("Ｂ");
                //}
                //else
                //{
                //    switch (Maps[i])
                //    {
                //        case 0:
                //            Console.ForegroundColor = ConsoleColor.DarkYellow;
                //            Console.Write("□");
                //            break;
                //        case 1:
                //            Console.ForegroundColor = ConsoleColor.Magenta;
                //            Console.Write("◎");
                //            break;
                //        case 2:
                //            Console.ForegroundColor = ConsoleColor.DarkBlue;
                //            Console.Write("☆");
                //            break;
                //        case 3:Console.ForegroundColor = ConsoleColor.DarkRed;
                //            Console.Write("▲");
                //            break;
                //        case 4:
                //            Console.ForegroundColor = ConsoleColor.Green;
                //            Console.Write("卐");
                //            break;
                //        default:
                //            break;
                //    }
                //}//if 
                #endregion
            }//for 
            //第一横行之后，应该换行
            Console.WriteLine();
            #endregion
            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                DrawStringMap(i);
                Console.WriteLine(str);
            }
            #endregion
            #region 第二横行
            for (int i = 64; i >= 35; i--)
            {
                DrawStringMap(i);
                Console.Write(str);
            }
            //画完第二横行，应该换行
            Console.WriteLine();
            #endregion
            #region 第二竖行
            for (int i = 65; i < 70; i++)
            {
                DrawStringMap(i);
                Console.WriteLine(str);
            }
            #endregion
            #region 第三横行
            for (int i = 70; i < 100; i++)
            {
                DrawStringMap(i);
                Console.Write(str);
            }
            Console.WriteLine();
            #endregion
        }
        /// <summary>
        /// 画地图中抽象出来的方法
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static void DrawStringMap(int i)
        {
            //string str = null;
            if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
            {
                str = "<>";
            }
            else if (PlayerPos[0] == i)
            {
                //Shift+空格  全角输入
                str = "Ａ";
            }
            else if (PlayerPos[1] == i)
            {
                str="Ｂ";
            }
            else
            {
                switch (Maps[i])
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        str="□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        str="◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        str="☆";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        str="▲";
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str="卐";
                        break;
                }
            }//if
            //return str;
        }
        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="playerNumber"></param>
        public static void PlayGame(int playerNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);
            Console.WriteLine("玩家{0}按任意键开始掷骰子", PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}掷出了{1}",PlayerNames[playerNumber],rNumber);
            PlayerPos[playerNumber] += rNumber;
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}按任意键开始行动",PlayerNames[playerNumber]);
            Console.ReadKey(true);
            Console.WriteLine("玩家{0}行动完了",PlayerNames[playerNumber]);
            Console.ReadKey(true);
            //玩家A有可能踩到了玩家B 方块 幸运轮盘 地雷 暂停 时空隧道
            if (PlayerPos[playerNumber] == PlayerPos[1 - playerNumber])
            {
                Console.WriteLine("玩家{0}踩到了玩家{1}，玩家{2}退6格",PlayerNames[playerNumber], PlayerPos[1 - playerNumber], PlayerPos[1 - playerNumber]);
                // Console.ReadKey(true);
                PlayerPos[1 - playerNumber] -= 6;
            }
            else//玩家踩到了关卡
            {
                ChangePos();
                switch (Maps[PlayerPos[playerNumber]])//玩家坐标
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到了方块，什么都没发生", PlayerNames[playerNumber]);
                        //Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}踩到了幸运转盘，请选择 1---交换位置  2---轰炸对方", PlayerNames[playerNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input=="1")
                            {
                                Console.WriteLine("玩家{0}与玩家{1}交换位置", PlayerNames[playerNumber], PlayerNames[1-playerNumber]);
                                Console.ReadKey(true);
                                int temp = PlayerPos[playerNumber];
                                PlayerPos[playerNumber] = PlayerPos[1 - playerNumber];
                                PlayerPos[1 - playerNumber] = temp;
                                Console.WriteLine("交换完成！！！按任意键继续游戏。");
                                //Console.ReadKey(true);
                                break;
                            }
                            else if (input=="2")
                            {
                                Console.WriteLine("玩家{0}轰炸玩家{1}，玩家{2}退6格", PlayerNames[playerNumber], PlayerNames[1 - playerNumber], PlayerNames[1 - playerNumber]);
                                Console.ReadKey(true);
                                PlayerPos[1 - playerNumber] -= 6;
                                Console.WriteLine("玩家{0}退了6格", PlayerNames[1 - playerNumber]);
                                //Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或者2，请重新输入");
                                input = Console.ReadLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("玩家{0}踩到了地雷，退6格", PlayerNames[playerNumber]);
                        //Console.ReadKey(true);
                        PlayerPos[playerNumber] -= 6;
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到了暂停，停止一回合",PlayerNames[playerNumber]);
                        Flags[playerNumber] = true;
                        //Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到了时空隧道，前进10格", PlayerNames[playerNumber]);
                        //Console.ReadKey(true);
                        PlayerPos[playerNumber] += 10;
                        break;
                }//switch
            }//else
            Console.ReadKey(true);
            ChangePos();
            Console.Clear();
            DrawMap();
        }
        /// <summary>
        /// 玩家坐标发生改变时调用
        /// </summary>
        public static void ChangePos()
        {
            if (PlayerPos[0]<0)
            {
                PlayerPos[0] = 0;
            }
            if (PlayerPos[0]>99)
            {
                PlayerPos[0] = 99;
            }
            if (PlayerPos[1] < 0)
            {
                PlayerPos[1] = 0;
            }
            if (PlayerPos[1] > 99)
            {
                PlayerPos[1] = 99;
            }
        }
        /// <summary>
        /// 胜利标志
        /// </summary>
        public static void Win()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                          ◆                      ");
            Console.WriteLine("                    ■                  ◆               ■        ■");
            Console.WriteLine("      ■■■■  ■  ■                ◆■         ■    ■        ■");
            Console.WriteLine("      ■    ■  ■  ■              ◆  ■         ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■       ■■■■■■■   ■    ■        ■");
            Console.WriteLine("      ■■■■ ■   ■                ●■●       ■    ■        ■");
            Console.WriteLine("      ■    ■      ■               ● ■ ●      ■    ■        ■");
            Console.WriteLine("      ■    ■ ■■■■■■         ●  ■  ●     ■    ■        ■");
            Console.WriteLine("      ■■■■      ■             ●   ■   ■    ■    ■        ■");
            Console.WriteLine("      ■    ■      ■            ■    ■         ■    ■        ■");
            Console.WriteLine("      ■    ■      ■                  ■               ■        ■ ");
            Console.WriteLine("     ■     ■      ■                  ■           ●  ■          ");
            Console.WriteLine("    ■    ■■ ■■■■■■             ■              ●         ●");
            Console.ResetColor();
        }
    }
}
