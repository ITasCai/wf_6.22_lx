using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblxin_Click(object sender, EventArgs e)
        {

        }

        private void txtxin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            //定义一个变量,显示个人信息
            string info = "";
            info+= "个人信息：\r\n";
            info += "姓名为："+txtname.Text.Trim() + "\r\n";
            if (rdonan.AutoCheck==true)
            {
                info += "性别为：男"+"\r\n";
            }
            else
            {
                info += "性别为：女" + "\r\n";
            }
            info += "爱好:";
            //在复选框中遍历显示爱好
            foreach (CheckBox ck in grpkuang.Controls)
            {
                if (ck.Checked==true)
                {
                    info += ck.Text + " ";
                }
            }
            txtxin.Text = info;
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
