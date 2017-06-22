namespace wf_6._22_lx
{
    partial class formStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labshow = new System.Windows.Forms.Label();
            this.labname = new System.Windows.Forms.Label();
            this.labpass = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lablx = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labshow
            // 
            this.labshow.AutoSize = true;
            this.labshow.Font = new System.Drawing.Font("宋体", 18F);
            this.labshow.Location = new System.Drawing.Point(99, 9);
            this.labshow.Name = "labshow";
            this.labshow.Size = new System.Drawing.Size(154, 24);
            this.labshow.TabIndex = 0;
            this.labshow.Text = "学生登录系统";
            // 
            // labname
            // 
            this.labname.AutoSize = true;
            this.labname.Font = new System.Drawing.Font("宋体", 12F);
            this.labname.Location = new System.Drawing.Point(23, 56);
            this.labname.Name = "labname";
            this.labname.Size = new System.Drawing.Size(64, 16);
            this.labname.TabIndex = 1;
            this.labname.Text = "用户名:";
            // 
            // labpass
            // 
            this.labpass.AutoSize = true;
            this.labpass.Font = new System.Drawing.Font("宋体", 12F);
            this.labpass.Location = new System.Drawing.Point(25, 108);
            this.labpass.Name = "labpass";
            this.labpass.Size = new System.Drawing.Size(56, 16);
            this.labpass.TabIndex = 2;
            this.labpass.Text = "密码：";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(127, 56);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(168, 21);
            this.txtname.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(127, 102);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(168, 21);
            this.txtpass.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(45, 194);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "登录";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(220, 194);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(75, 23);
            this.btnON.TabIndex = 6;
            this.btnON.Text = "退出";
            this.btnON.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "大一",
            "大二",
            "大三",
            "大四"});
            this.comboBox1.Location = new System.Drawing.Point(127, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // lablx
            // 
            this.lablx.AutoSize = true;
            this.lablx.Font = new System.Drawing.Font("宋体", 12F);
            this.lablx.Location = new System.Drawing.Point(26, 155);
            this.lablx.Name = "lablx";
            this.lablx.Size = new System.Drawing.Size(88, 16);
            this.lablx.TabIndex = 8;
            this.lablx.Text = "登录类型：";
            // 
            // formStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(369, 241);
            this.Controls.Add(this.lablx);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.labpass);
            this.Controls.Add(this.labname);
            this.Controls.Add(this.labshow);
            this.Name = "formStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.formStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labshow;
        private System.Windows.Forms.Label labname;
        private System.Windows.Forms.Label labpass;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lablx;
    }
}