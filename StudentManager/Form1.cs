using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstz.Items.Add("狗蛋");
            lstz.Items.Add("斩杀");
            lstz.Items.Add("李四");
            lstz.Items.Add("王五");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_name_Click(object sender, EventArgs e)
        {
            string strStu = "优秀学员名单："+"\n";
            
            //循环显示优秀学员名单
            for (int i = 0; i < lsty.Items.Count; i++)
            {
                strStu += lsty.Items[i]+"\n";
             
            }
            //显示优秀学员
            MessageBox.Show(strStu);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btny_Click(object sender, EventArgs e)
        {
            if (lstz.SelectedIndex >= 0)
            {
                //MessageBox.Show(lstOne.SelectedIndex.ToString());
                //把左边选中的值添加到右边
                lsty.Items.Add(lstz.SelectedItem);
                //移除左边刚刚添加到右边的值
                lstz.Items.RemoveAt(lstz.SelectedIndex);
            }
        }

        private void btnz_Click(object sender, EventArgs e)
        {
            if (lsty.SelectedIndex >= 0)
            {
                //MessageBox.Show(lstOne.SelectedIndex.ToString());
                //把左边选中的值添加到右边
                lstz.Items.Add(lsty.SelectedItem);
                //移除左边刚刚添加到右边的值
                lsty.Items.RemoveAt(lsty.SelectedIndex);
            }
        }
    }
}
