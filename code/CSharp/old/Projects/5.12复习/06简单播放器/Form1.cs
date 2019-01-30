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

namespace _06简单播放器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }
        /// <summary>
        /// 停止播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
            btnPlayOrPause.Text = "播放";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序加载时，取消程序的自动播放功能
            musicPlayer.settings.autoStart = true;
            label1.Image = Image.FromFile(@"C:\Users\PC\Desktop\放音.png");
        }
        /// <summary>
        /// 播放暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlayOrPause_Click(object sender, EventArgs e)
        {
            if (btnPlayOrPause.Text == "播放")
            {
                if (musicPlayer.URL != listPath[listBox1.SelectedIndex])
                {
                    musicPlayer.URL = listPath[listBox1.SelectedIndex];
                }
                musicPlayer.Ctlcontrols.play();
                btnPlayOrPause.Text = "暂停";
            }
            else
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayOrPause.Text = "播放";
            }
        }
        //存储音乐文件的全路径
        List<string> listPath = new List<string>();
        /// <summary>
        /// 打开对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"G:\Music";
            ofd.Title = "请选择要播放的音乐文件";
            ofd.Filter = "MP3文件|*.mp3|音乐文件|*.avi|所有文件|*.*";
            ofd.Multiselect = true;
            ofd.ShowDialog();
            //获得文本框中选择文件的全路径
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的全路径存储到泛型集合中
                listPath.Add(path[i]);
                //将音乐文件的文件名存储到ListBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }
        /// <summary>
        /// 双击播放对应的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请选择要播放的音乐文件");
                return;
            }
            try
            {
                musicPlayer.URL = listPath[listBox1.SelectedIndex];
                btnPlayOrPause.Text = "暂停";
            }
            catch
            {
            }
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            #region 测试
            //if (listBox1.SelectedIndex == listPath.Count)
            //{
            //    listBox1.SelectedIndex = 0;
            //}
            //else
            //{
            //    listBox1.SelectedIndex=+1;
            //} 
            #endregion
            //获得当前选中项的索引
            int index = listBox1.SelectedIndex;
            //清空所有选中项的索引
            listBox1.SelectedIndices.Clear();
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            musicPlayer.URL = listPath[index];
            listBox1.SelectedIndex = index;
        }
        /// <summary>
        /// 点击上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            musicPlayer.URL = listPath[index];
            listBox1.SelectedIndex = index;
        }
        /// <summary>
        /// 点击删除选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获得选中项的个数
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //先删集合
                listPath.RemoveAt(listBox1.SelectedIndex);
                //再删列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
        /// <summary>
        /// 点击放音或者静音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Tag.ToString() == "0")
            {
                //静音
                musicPlayer.settings.mute = true;
                label1.Tag = 1;
                label1.Image = Image.FromFile(@"C:\Users\PC\Desktop\静音.png");
            }
            else
            {
                //放音
                musicPlayer.settings.mute = false;
                label1.Tag = 0;
                label1.Image = Image.FromFile(@"C:\Users\PC\Desktop\放音.png");
            }
        }
        /// <summary>
        /// 放大音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume += 5;
        }
        /// <summary>
        /// 减小音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume -= 5;
        }
        /// <summary>
        /// 自动播放下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果播放器的状态等于正在播放中
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                label1.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" + musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;
                //如果歌曲的播放时间==歌曲的总时间，则下一曲
                if (musicPlayer.currentMedia.duration <= musicPlayer.Ctlcontrols.currentPosition+1)
                {
                    //获得当前选中项的索引
                    int index = listBox1.SelectedIndex;
                    //清空所有选中项的索引
                    listBox1.SelectedIndices.Clear();
                    index++;
                    if (index == listBox1.Items.Count)
                    {
                        index = 0;
                    }
                    musicPlayer.URL = listPath[index];
                    listBox1.SelectedIndex = index;
                }
            }

        }
    }
}
