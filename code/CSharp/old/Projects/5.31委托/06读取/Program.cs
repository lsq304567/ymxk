using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _06读取
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 读取xml
            //XmlDocument doc = new XmlDocument();
            //doc.Load("book.xml");
            ////获得根节点
            //XmlElement books = doc.DocumentElement;
            ////获得子节点
            //XmlNodeList xn1 = doc.ChildNodes;
            //foreach (XmlNode item in xn1)
            //{
            //    Console.WriteLine(item.InnerText);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 读取标签的属性
            //XmlDocument doc = new XmlDocument();
            //doc.Load("Order.xml");
            //XmlElement order = doc.DocumentElement;
            //XmlNodeList xn1 = doc.SelectNodes("/Order/Items/OrderItem");
            //foreach (XmlNode node in xn1)
            //{
            //    Console.WriteLine(node.Attributes["Name"].Value);
            //    Console.WriteLine(node.Attributes["Count"].Value);
            //}
            //Console.ReadKey(); 
            #endregion

            #region 删除节点
            XmlDocument doc = new XmlDocument();
            doc.Load("Order.xml");
            XmlNode xn = doc.SelectSingleNode("/Order/Items");
            xn.RemoveAll();
            doc.Save("Order.xml");
            Console.WriteLine("删除成功");
            Console.ReadKey(); 
            #endregion


        }
    }
}
