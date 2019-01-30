using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08简易计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d1 = Convert.ToDouble(textBox1.Text);
                double d2 = Convert.ToDouble(textBox2.Text);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        label1.Text = (d1 + d2).ToString();
                        break;
                    case 1:
                        label1.Text = (d1 - d2).ToString();
                        break;
                    case 2:
                        label1.Text = (d1 * d2).ToString();
                        break;
                    case 3:
                        label1.Text = (d1 / d2).ToString();
                        break;
                    default:
                        MessageBox.Show("请选择正确的操作符");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("请输入数字");
            }
                
        }
    }
}
