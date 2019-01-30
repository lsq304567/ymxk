using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _05追加
{
    class Program
    {
        static void Main(string[] args)
        {
            //追加XML文档
            XmlDocument doc = new XmlDocument();
            XmlElement books;
            if (File.Exists("Book.xml"))
            {
                //如果文档存在，加载XML
                doc.Load("Book.xml");
                //获得文档的根节点
                books = doc.DocumentElement;
            }
            else
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                doc.AppendChild(dec);
                books = doc.CreateElement("books");
                doc.AppendChild(books);
            }
            //5)给根节点添加子节点
            XmlElement book1 = doc.CreateElement("book");
            books.AppendChild(book1);

            //6）给book添加子节点
            XmlElement name1 = doc.CreateElement("name");
            name1.InnerText = "C#开发大全";
            book1.AppendChild(name1);
            XmlElement price1 = doc.CreateElement("price");
            price1.InnerText = "110";
            book1.AppendChild(price1);
            XmlElement des1 = doc.CreateElement("des");
            des1.InnerText = "从入门到放弃";
            book1.AppendChild(des1);

            doc.Save("book.xml");
            Console.WriteLine("保存成功");
            Console.ReadKey();

        }
    }
}
