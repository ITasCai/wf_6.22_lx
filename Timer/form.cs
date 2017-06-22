using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //启动定时器
            tmrshow.Start();
        }

    
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //定义全局变量
        int i = 0;

        private void tmrshow_Tick(object sender, EventArgs e)
        {
            picimg.Image = imapic.Images[i];
            i++;
            if (i == imapic.Images.Count)
            {
                i = 0;
            }
        }
    }
}
