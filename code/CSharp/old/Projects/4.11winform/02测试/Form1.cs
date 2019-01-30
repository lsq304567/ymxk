using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02测试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            MessageBox.Show("转换成功");
        }
        /// <summary>
        /// 弹出窗体2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            //在内存中创建窗体2
            Form2 frm2 = new Form2();
            //展示当前窗体
            frm2.Show();

        }

        private void button3_Layout(object sender, LayoutEventArgs e)
        {
            Test._fr1Test = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Test._fr1Test = this;
        }
    }
}
