using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03爱情玩笑
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你呦思密达");
            this.Close();
        }
        /// <summary>
        /// 当鼠标进入按钮的可见范围是，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //按钮活动的最大范围是：窗体宽度减去按钮宽度
            int x = this.ClientSize.Width - button2.Width;
            int y = this.ClientSize.Height - button2.Height;
            Random r = new Random();
            //给按钮一个随机坐标
            button2.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你这个屌丝点到了");
            this.Close();
        }
    }
}
