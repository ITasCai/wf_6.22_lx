using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //添加年级
            comNJ.Items.Add("一年级");
            comNJ.Items.Add("二年级");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comNJ_SelectedIndexChanged(object sender, EventArgs e)
        {
            //先清除原来显示的内容
            lstShow.Items.Clear();
            //添加内容
            switch (comNJ.Text)
            {
                case "一年级":
                    lstShow.Items.Add("狗蛋");
                    lstShow.Items.Add("小蛋");
                    lstShow.Items.Add("蛋仔");
                    break;
                case "二年级":
                    lstShow.Items.Add("张三");
                    lstShow.Items.Add("李四");
                    lstShow.Items.Add("王五");
                    break;
            }
        }

        private void lstShow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定要退出吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }
    }
}
