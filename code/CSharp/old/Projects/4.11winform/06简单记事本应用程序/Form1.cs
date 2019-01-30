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

namespace _06简单记事本应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载时隐藏部分功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible = false;
            button4.Visible = false;
            textBox3.Visible = false;
        }
        /// <summary>
        /// 判断是否登陆成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string pwd = textBox2.Text;
            if (name=="admin"&&pwd=="admin")
            {
                MessageBox.Show("欢迎进入记事本应用程序");
                button3.Visible = true;
                button4.Visible = true;
                textBox3.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
            }
            else//登录失败
            {
                MessageBox.Show("用户名或密码错误，请重新登录");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        /// <summary>
        /// 自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text=="自动换行")
            {
                //取消自动换行
                textBox3.WordWrap = true;
                button3.Text = "取消自动换行";
            }
            else
            {
                textBox3.WordWrap = false;
                button3.Text = "自动换行";
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            using (FileStream fsWrite=new FileStream(@"C:\Users\PC\Desktop\new.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str = textBox3.Text;
                byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, str.Length);
            }
            MessageBox.Show("保存成功");
        }
    }
}
