using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //点击弹出对话框
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文本文件呦亲 O(∩_∩)O~";//标题
            ofd.Multiselect = true;  //设置多选
            //初始化目录
            ofd.InitialDirectory = @"C:\Users\PC\Desktop";
            //设置文件类型
            ofd.Filter = "文本文件|*.txt|音乐文件|*.mp3|图片文件|*.jpg|所有文件|*.*";

            //展示对话框
            ofd.ShowDialog();

            //获得在打开文本框中选中文件的路径
            string path = ofd.FileName;
            if (path=="")
            {
                return;
            }
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                while (true)
                {
                    //实际读取到的字节数
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    if (r==0)
                    {
                        break;
                    }
                    textBox1.Text = Encoding.Default.GetString(buffer, 0, r);
                }
            }


        }
    }
}
