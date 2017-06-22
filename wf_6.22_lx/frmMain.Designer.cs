namespace wf_6._22_lx
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labshow = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.lbapass = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.texpass = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.btnDj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labshow
            // 
            this.labshow.AutoSize = true;
            this.labshow.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labshow.Location = new System.Drawing.Point(88, 13);
            this.labshow.Name = "labshow";
            this.labshow.Size = new System.Drawing.Size(94, 21);
            this.labshow.TabIndex = 0;
            this.labshow.Text = "我的窗体";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Location = new System.Drawing.Point(13, 54);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(41, 12);
            this.labname.TabIndex = 1;
            this.labname.Text = "姓名：";
            // 
            // lbapass
            // 
            this.lbapass.AutoSize = true;
            this.lbapass.Location = new System.Drawing.Point(15, 92);
            this.lbapass.Name = "lbapass";
            this.lbapass.Size = new System.Drawing.Size(35, 12);
            this.lbapass.TabIndex = 2;
            this.lbapass.Text = "密码:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(82, 54);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 3;
            this.txtname.Text = "张三";
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // texpass
            // 
            this.texpass.Location = new System.Drawing.Point(82, 92);
            this.texpass.Name = "texpass";
            this.texpass.PasswordChar = '*';
            this.texpass.Size = new System.Drawing.Size(100, 21);
            this.texpass.TabIndex = 4;
            this.texpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(17, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "提交";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(122, 150);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(75, 23);
            this.btnON.TabIndex = 6;
            this.btnON.Text = "取消";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // btnDj
            // 
            this.btnDj.Location = new System.Drawing.Point(214, 149);
            this.btnDj.Name = "btnDj";
            this.btnDj.Size = new System.Drawing.Size(75, 23);
            this.btnDj.TabIndex = 7;
            this.btnDj.Text = "点击";
            this.btnDj.UseVisualStyleBackColor = true;
            this.btnDj.Click += new System.EventHandler(this.btnDj_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(296, 262);
            this.Controls.Add(this.btnDj);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.texpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbapass);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.labshow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "第一个窗体";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labshow;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label lbapass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox texpass;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button btnDj;
    }
}

