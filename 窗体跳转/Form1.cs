using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体跳转
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Towfrom t = new Towfrom();
            
            t.stuname = txt1.Text.Trim();
            t.stuage = txt2.Text.Trim();
            t.ShowDialog();
        }
    }
}
