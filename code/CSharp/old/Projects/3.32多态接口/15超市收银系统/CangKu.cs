using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15超市收银系统
{
    class CangKu
    {
        //存储数据
        List<List<ProductFatter>> list = new List<List<ProductFatter>>();
        /// <summary>
        /// 向用户展示货物
        /// </summary>
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("我们超市有："+item[0].Name+","+"\t有"+ item.Count+"个，"+"\t每个"+ item[0].Price+"元钱");
            }
        }


        /// <summary>
        /// 在创建仓库的时候  向仓库添加货架
        /// </summary>
        public CangKu()
        {
            list.Add(new List<ProductFatter>());
            list.Add(new List<ProductFatter>());
            list.Add(new List<ProductFatter>());
            list.Add(new List<ProductFatter>());
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">数量</param>
        public void JinPros(string strType,int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "鸿基笔记本"));
                            break;
                    case "SamSung":list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "棒子手机"));
                        break;
                    case "JiangYou":list[2].Add(new JiangYou(Guid.NewGuid().ToString(), 10, "老抽酱油"));
                        break;
                    case "Banana":list[3].Add(new Banana(Guid.NewGuid().ToString(), 50, "大香蕉"));
                        break;
                    default:
                        break;
                }
            }
        }
        /// <summary>
        /// 从仓库中提取货物
        /// </summary>
        /// <param name="strType">货物类型</param>
        /// <param name="count">数量</param>
        /// <returns>取到的货物数组</returns>
        public ProductFatter[] QuPros(string strType,int count)
        {
            ProductFatter[] pros = new ProductFatter[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung":pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "JiangYou":pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana":pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                    default:
                        break;
                }
            }
            return pros;
        }


    }
}
