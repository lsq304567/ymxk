using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒了~~~！！！关不掉了吧");
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
        /// <summary>
        /// 每隔一秒钟就把当前时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
            if (DateTime.Now.Hour==21&&DateTime.Now.Minute==10&&DateTime.Now.Second==50)
            {
                SoundPlayer sp = new SoundPlayer(@"");
                sp.Play();
            }
        }
        /// <summary>
        /// 当窗体加载时将系统时间赋值给我的label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }
    }
}
