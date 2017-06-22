using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ShuJufrom
{
    public partial class Form1 : Form
    {
        //定义连接对象
        SqlConnection sqlcon = null;
        //创建连接字符串
        string strcon = "Data Source=HP201-1;Initial Catalog=Student;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //吊事显示数据的方法
            StudentShow();
        }
       /// <summary>
       /// 查询所有信息
       /// </summary>
        private void StudentShow() {
            //实例化连接对象
            sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //定义查询字符串
                string strsql = "SELECT *FROM dbo.tb_stuInfo";
                //定义命令对象
                SqlCommand com = new SqlCommand(strsql, sqlcon);
                //定义一个只读只进的记录的对象
                SqlDataReader dr = com.ExecuteReader();

                lstshow.Items.Clear();
                while (dr.Read())
                {
                    string id = dr[0].ToString();
                    string name = dr[1].ToString();
                    string sex = dr[2].ToString();
                    string age = dr[3].ToString();
                    string beizhu = dr[4].ToString();
                    //显示在列表中
                    lstshow.Items.Add(id + "\t" + name + "\t" + sex + "\t" + age + "\t" + beizhu + "\t");
                }
                //关闭记录集
                dr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("错误提示" + ex.Message);
            }
            finally {
                sqlcon.Close();
            }

        }

        /// <summary>
        /// 点击listbox每行数据，对应显示值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstshow.SelectedIndex>=0)
            {
                string str = lstshow.SelectedItem.ToString();
                string[] stu = str.Split();
                //显示当前记录
                txtid.Text = stu[0];
                txtname.Text = stu[1];
                if (stu[2]=="男")
                {
                    comsex.SelectedIndex= 0;
                }
                else
                {
                    comsex.SelectedIndex = 1;
                }
                txtage.Text = stu[3];
                txtbz.Text = stu[4];
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //实例化连接对象
            sqlcon = new SqlConnection(strcon);
            try
            {
                //打开连接
                sqlcon.Open();
                //定义查询字符串
                string strsql = string.Format("INSERT INTO dbo.tb_stuInfo( s_name, s_gender, s_age, s_romark )VALUES  ('{0}','{1}','{2}','{3}')",txtname.Text.Trim(),comsex.Text,txtage.Text.Trim(),txtbz.Text);
                //定义命令对象
                SqlCommand com = new SqlCommand(strsql, sqlcon);
                int num= com.ExecuteNonQuery();
                if (num>0)
                {
                    MessageBox.Show("添加成功！");
                    StudentShow();
                }
                else
                {
                    MessageBox.Show("添加失败！");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("错误提示" + ex.Message);
            }
            finally {
                sqlcon.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bthxg_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim().Length==0)
            {
                MessageBox.Show("请选择学生的信息在修改");

            }
            sqlcon = new SqlConnection(strcon);
                try
                {
                    //打开连接
                    sqlcon.Open();
                    //定义查询字符串
                    string strsql = string.Format("UPDATE dbo.tb_stuInfo SET s_name='{0}', s_gender='{1}', s_age='{2}',s_romark='{3}' where s_id='{4}'", txtname.Text.Trim(), comsex.Text, txtage.Text.Trim(), txtbz.Text,txtid.Text.Trim());
                    //定义命令对象
                    SqlCommand com = new SqlCommand(strsql, sqlcon);
                    int num = com.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("修改成功！");
                        StudentShow();
                    }
                    else
                    {
                        MessageBox.Show("修改失败！");
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("错误提示" + ex.Message);
                }
                finally
                {
                    sqlcon.Close();
                }

            }
     

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bthdelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Trim().Length == 0)
            {
                MessageBox.Show("请选择学生的信息在删除");

            }
            sqlcon = new SqlConnection(strcon);
                try
                {
                    //打开连接
                    sqlcon.Open();
                    //定义查询字符串
                    string strsql = string.Format("DELETE dbo.tb_stuInfo WHERE s_id='{0}'", txtid.Text.Trim());
                    //定义命令对象
                    SqlCommand com = new SqlCommand(strsql, sqlcon);
                    int num = com.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("删除成功！");
                        StudentShow();
                    }
                    else
                    {
                        MessageBox.Show("删除失败！");
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show("错误提示" + ex.Message);
                }
                finally
                {
                    sqlcon.Close();
                }

           
        }

        private void bthon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
