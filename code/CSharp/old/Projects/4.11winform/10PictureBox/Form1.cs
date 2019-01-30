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

namespace _10PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\PC\Desktop\Picture\201611231437.jpg");
        }
        //获得指定文件夹的所有文件的路径
        string[] path = Directory.GetFiles(@"C:\Users\PC\Desktop\Picture");
        int i = 0;
        /// <summary>
        /// 点击更换下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i <0)
            {
                i = path.Length-1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
