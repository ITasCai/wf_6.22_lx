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
    public partial class formStudent : Form
    {
        public formStudent()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Trim().Equals(string.Empty)|| txtpass.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else if (!txtname.Text.Equals("狗蛋") || !txtpass.Text.Equals("123"))
            {
                MessageBox.Show("用户名或密码错误！");
            }
            else
            {
                MessageBox.Show("登录成功！");
            }
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
