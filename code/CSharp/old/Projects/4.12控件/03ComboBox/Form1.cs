﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //通过代码给下拉框添加数据
            comboBox2.Items.Add("张三");
            comboBox2.Items.Add("李四");
            comboBox2.Items.Add("王五");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
        }
    }
}
