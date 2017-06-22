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
    public partial class Towfrom : Form
    {
        public string stuname;
        public string stuage;

        public Towfrom()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Towfrom_Load(object sender, EventArgs e)
        {
            txtshow.Text = "姓名:" + stuname;
            txtshow.Text += "年龄:" + stuage;
        }
    }
}
