using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_6._22_lx
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtname.Text = "狗蛋";
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (BackColor == Color.Red)
            {
                BackColor = Color.Yellow;
            }
            else if (BackColor == Color.Yellow)
            {
                BackColor = Color.Red;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (texpass.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码");
            }
            else if (!texpass.Text.Trim().Equals("admin"))
            {
                MessageBox.Show("请输入正确密码");
            }
            else
            {
                MessageBox.Show(txtname.Text);
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDj_Click(object sender, EventArgs e)
        {
            if (BackColor==Color.Red)
            {
                BackColor = Color.Yellow;
            }
            else if (BackColor == Color.Yellow)
            {
                BackColor = Color.Red;
            }
        }
    }
}
