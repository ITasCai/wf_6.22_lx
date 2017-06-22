namespace ShuJufrom
{
    partial class Form1
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
            this.lstshow = new System.Windows.Forms.ListBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.comsex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.bthxg = new System.Windows.Forms.Button();
            this.bthdelete = new System.Windows.Forms.Button();
            this.bthon = new System.Windows.Forms.Button();
            this.txtbz = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstshow
            // 
            this.lstshow.FormattingEnabled = true;
            this.lstshow.ItemHeight = 12;
            this.lstshow.Location = new System.Drawing.Point(12, 12);
            this.lstshow.Name = "lstshow";
            this.lstshow.Size = new System.Drawing.Size(364, 88);
            this.lstshow.TabIndex = 0;
            this.lstshow.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(12, 123);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(29, 12);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "学号";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtid.Location = new System.Drawing.Point(84, 113);
            this.txtid.Name = "txtid";
            this.txtid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtid.Size = new System.Drawing.Size(100, 21);
            this.txtid.TabIndex = 2;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(12, 158);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(29, 12);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "姓名";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(84, 155);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 4;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(12, 191);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(29, 12);
            this.lblsex.TabIndex = 5;
            this.lblsex.Text = "性别";
            // 
            // comsex
            // 
            this.comsex.FormattingEnabled = true;
            this.comsex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comsex.Location = new System.Drawing.Point(84, 188);
            this.comsex.Name = "comsex";
            this.comsex.Size = new System.Drawing.Size(121, 20);
            this.comsex.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "备注";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(60, 340);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // bthxg
            // 
            this.bthxg.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.bthxg.Location = new System.Drawing.Point(246, 340);
            this.bthxg.Name = "bthxg";
            this.bthxg.Size = new System.Drawing.Size(75, 23);
            this.bthxg.TabIndex = 10;
            this.bthxg.Text = "修改";
            this.bthxg.UseVisualStyleBackColor = true;
            this.bthxg.Click += new System.EventHandler(this.bthxg_Click);
            // 
            // bthdelete
            // 
            this.bthdelete.Location = new System.Drawing.Point(60, 382);
            this.bthdelete.Name = "bthdelete";
            this.bthdelete.Size = new System.Drawing.Size(75, 23);
            this.bthdelete.TabIndex = 11;
            this.bthdelete.Text = "删除";
            this.bthdelete.UseVisualStyleBackColor = true;
            this.bthdelete.Click += new System.EventHandler(this.bthdelete_Click);
            // 
            // bthon
            // 
            this.bthon.Location = new System.Drawing.Point(246, 382);
            this.bthon.Name = "bthon";
            this.bthon.Size = new System.Drawing.Size(75, 23);
            this.bthon.TabIndex = 12;
            this.bthon.Text = "退出";
            this.bthon.UseVisualStyleBackColor = true;
            this.bthon.Click += new System.EventHandler(this.bthon_Click);
            // 
            // txtbz
            // 
            this.txtbz.Location = new System.Drawing.Point(84, 253);
            this.txtbz.Multiline = true;
            this.txtbz.Name = "txtbz";
            this.txtbz.Size = new System.Drawing.Size(274, 52);
            this.txtbz.TabIndex = 8;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(14, 218);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(29, 12);
            this.lblage.TabIndex = 14;
            this.lblage.Text = "年龄";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(84, 218);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 21);
            this.txtage.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 417);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.bthon);
            this.Controls.Add(this.bthdelete);
            this.Controls.Add(this.bthxg);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtbz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comsex);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lstshow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "学生管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstshow;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.ComboBox comsex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button bthxg;
        private System.Windows.Forms.Button bthdelete;
        private System.Windows.Forms.Button bthon;
        private System.Windows.Forms.TextBox txtbz;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.TextBox txtage;
    }
}

