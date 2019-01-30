using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01使用GDI绘制简单的图形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //一根笔 颜色 纸  两点  绘制直线的对象
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            //创建GDI对象
            Graphics g = CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            //创建两个点
            Point p1 = new Point(20, 50);
            Point p2 = new Point(400, 500);
            g.DrawLine(pen, p1, p1);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            label1.Text = i.ToString();
            //创建GDI对象
            Graphics g = CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Red);
            //创建两个点
            Point p1 = new Point(3, 5);
            Point p2 = new Point(250, 250);
            g.DrawLine(pen, p1, p1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Yellow);
            Size size = new Size(180, 80);
            Rectangle rec = new Rectangle(new Point(50, 50), size);
            g.DrawRectangle(pen, rec);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Brushes.Blue);
            Size size = new Size(180, 180);
            Rectangle rec = new Rectangle(new Point(150, 150), size);
            g.DrawPie(pen, rec, 30, 130);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawString("国超是最帅的", new Font("宋体",28,FontStyle.Underline), Brushes.Yellow, new Point(150, 200));
        }
    }
}
