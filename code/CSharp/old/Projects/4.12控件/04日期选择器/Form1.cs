using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载时，将年份添加到下拉框
            //获得当前年份
            int year = DateTime.Now.Year;
            for (int i = year; i >= 1949; i--)
            {
                cboYear.Items.Add(i + "年");
            }
        }
        /// <summary>
        /// 当年份发生改变时，加载月份
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //添加月份前，应该清空月份
            cboMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i + "月");
            }
        }
        /// <summary>
        /// 当月份发生改变时，加载天
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDays.Items.Clear();  //窗体载入时初始化
            int day = 0;
            string strMonth = cboMonth.SelectedItem.ToString().Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0];
            string strYear = cboYear.SelectedItem.ToString().Split(new char[] { '年' })[0];
            int month = Convert.ToInt32(strMonth);
            int year = Convert.ToInt32(strYear);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day = 31;
                    break;
                case 2:
                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                    {
                        day = 29;
                    }
                    else
                    {
                        day = 28;
                    }
                    break;
                default:day = 30;
                    break;
            }
            for (int i = 1; i <=day; i++)
            {
                cboDays.Items.Add(i+"日");
            }


        }
    }
}
