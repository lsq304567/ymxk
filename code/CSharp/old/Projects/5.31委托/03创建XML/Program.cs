using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Text;
using System.Threading.Tasks;

namespace _03创建XML
{
    class Program
    {
        static void Main(string[] args)
        {
            //通过代码创建XML文档
            //1)引用命名空间
            //2)创建XML对象
            XmlDocument doc = new XmlDocument();
            //3)创建第一行描述信息
            XmlDeclaration dec= doc.CreateXmlDeclaration("1.0", "utf-8", null);
            doc.AppendChild(dec);
            //4)创建根节点
            XmlElement books = doc.CreateElement("books");
            //将根节点添加到文档中
            doc.AppendChild(books);
            
            //5)给根节点添加子节点
            XmlElement book1 = doc.CreateElement("book");
            books.AppendChild(book1);

            //6）给book添加子节点
            XmlElement name1 = doc.CreateElement("name");
            name1.InnerText = "金瓶梅";
            book1.AppendChild(name1);
            XmlElement price1 = doc.CreateElement("price");
            price1.InnerText = "10";
            book1.AppendChild(price1);
            XmlElement des1 = doc.CreateElement("des");
            des1.InnerText = "好看，不解释";
            book1.AppendChild(des1);

            XmlElement book2 = doc.CreateElement("book");
            books.AppendChild(book2);
            XmlElement name2 = doc.CreateElement("name");
            name2.InnerText = "金瓶梅";
            book2.AppendChild(name2);
            XmlElement price2 = doc.CreateElement("price");
            price2.InnerText = "10";
            book2.AppendChild(price2);
            XmlElement des2 = doc.CreateElement("des");
            des2.InnerText = "好看，不解释";
            book2.AppendChild(des2);

            doc.Save("Book.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();


        }
    }
}
