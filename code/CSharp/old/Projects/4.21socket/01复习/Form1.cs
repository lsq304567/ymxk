using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> listSongs = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\PC\Desktop\music";
            ofd.Filter = "wav音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            //获得我们在文件夹中选择的所有全路径
            string[] path = ofd.FileNames;
            //string path = ofd.FileName;
            //listBox1.Items.AddRange(path);
            listSongs.AddRange(path);
            for (int i = 0; i < path.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SoundPlayer sp = new SoundPlayer();
        /// <summary>
        /// 双击播放列表时，播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            sp.Play();

        }
        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index == -1)
            {
                index = listSongs.Count-1;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index++;
            if (index==listSongs.Count)
            {
                index = 0;
            }
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
            //if (listBox1.SelectedIndex == listSongs.Count-2)
            //{
            //    listBox1.SelectedIndex = -1;
            //}
            //listBox1.SelectedIndex = +1;
            //sp.SoundLocation = listSongs[listBox1.SelectedIndex];
            //sp.Play();
        }
    }
}
