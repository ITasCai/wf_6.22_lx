namespace Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblsex = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdonan = new System.Windows.Forms.RadioButton();
            this.rdonv = new System.Windows.Forms.RadioButton();
            this.ceklan = new System.Windows.Forms.CheckBox();
            this.cekzu = new System.Windows.Forms.CheckBox();
            this.cekshu = new System.Windows.Forms.CheckBox();
            this.cekyou = new System.Windows.Forms.CheckBox();
            this.grpkuang = new System.Windows.Forms.GroupBox();
            this.lbltou = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtxin = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.lblxin = new System.Windows.Forms.Label();
            this.grpkuang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(24, 22);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(41, 12);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "姓名：";
            this.lblname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(94, 13);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(26, 57);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(41, 12);
            this.lblsex.TabIndex = 2;
            this.lblsex.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "爱好：";
            // 
            // rdonan
            // 
            this.rdonan.AutoSize = true;
            this.rdonan.Location = new System.Drawing.Point(94, 57);
            this.rdonan.Name = "rdonan";
            this.rdonan.Size = new System.Drawing.Size(35, 16);
            this.rdonan.TabIndex = 4;
            this.rdonan.TabStop = true;
            this.rdonan.Text = "男";
            this.rdonan.UseVisualStyleBackColor = true;
            // 
            // rdonv
            // 
            this.rdonv.AutoSize = true;
            this.rdonv.Location = new System.Drawing.Point(177, 57);
            this.rdonv.Name = "rdonv";
            this.rdonv.Size = new System.Drawing.Size(35, 16);
            this.rdonv.TabIndex = 5;
            this.rdonv.TabStop = true;
            this.rdonv.Text = "女";
            this.rdonv.UseVisualStyleBackColor = true;
            this.rdonv.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ceklan
            // 
            this.ceklan.AutoSize = true;
            this.ceklan.Location = new System.Drawing.Point(20, 20);
            this.ceklan.Name = "ceklan";
            this.ceklan.Size = new System.Drawing.Size(60, 16);
            this.ceklan.TabIndex = 6;
            this.ceklan.Text = "打篮球";
            this.ceklan.UseVisualStyleBackColor = true;
            // 
            // cekzu
            // 
            this.cekzu.AutoSize = true;
            this.cekzu.Location = new System.Drawing.Point(100, 20);
            this.cekzu.Name = "cekzu";
            this.cekzu.Size = new System.Drawing.Size(60, 16);
            this.cekzu.TabIndex = 7;
            this.cekzu.Text = "踢足球";
            this.cekzu.UseVisualStyleBackColor = true;
            // 
            // cekshu
            // 
            this.cekshu.AutoSize = true;
            this.cekshu.Location = new System.Drawing.Point(20, 42);
            this.cekshu.Name = "cekshu";
            this.cekshu.Size = new System.Drawing.Size(48, 16);
            this.cekshu.TabIndex = 8;
            this.cekshu.Text = "看书";
            this.cekshu.UseVisualStyleBackColor = true;
            // 
            // cekyou
            // 
            this.cekyou.AutoSize = true;
            this.cekyou.Location = new System.Drawing.Point(100, 42);
            this.cekyou.Name = "cekyou";
            this.cekyou.Size = new System.Drawing.Size(60, 16);
            this.cekyou.TabIndex = 9;
            this.cekyou.Text = "玩游戏";
            this.cekyou.UseVisualStyleBackColor = true;
            // 
            // grpkuang
            // 
            this.grpkuang.Controls.Add(this.ceklan);
            this.grpkuang.Controls.Add(this.cekzu);
            this.grpkuang.Controls.Add(this.cekshu);
            this.grpkuang.Controls.Add(this.cekyou);
            this.grpkuang.Location = new System.Drawing.Point(74, 96);
            this.grpkuang.Name = "grpkuang";
            this.grpkuang.Size = new System.Drawing.Size(200, 82);
            this.grpkuang.TabIndex = 10;
            this.grpkuang.TabStop = false;
            // 
            // lbltou
            // 
            this.lbltou.AutoSize = true;
            this.lbltou.Location = new System.Drawing.Point(13, 200);
            this.lbltou.Name = "lbltou";
            this.lbltou.Size = new System.Drawing.Size(35, 12);
            this.lbltou.TabIndex = 11;
            this.lbltou.Text = "头像:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 94);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtxin
            // 
            this.txtxin.Location = new System.Drawing.Point(17, 312);
            this.txtxin.Multiline = true;
            this.txtxin.Name = "txtxin";
            this.txtxin.Size = new System.Drawing.Size(257, 93);
            this.txtxin.TabIndex = 14;
            this.txtxin.TextChanged += new System.EventHandler(this.txtxin_TextChanged);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(26, 411);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 15;
            this.btnok.Text = "提交";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(159, 411);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(75, 23);
            this.btnno.TabIndex = 16;
            this.btnno.Text = "取消";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // lblxin
            // 
            this.lblxin.AutoSize = true;
            this.lblxin.Location = new System.Drawing.Point(15, 297);
            this.lblxin.Name = "lblxin";
            this.lblxin.Size = new System.Drawing.Size(59, 12);
            this.lblxin.TabIndex = 17;
            this.lblxin.Text = "个人信息:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 446);
            this.Controls.Add(this.lblxin);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtxin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltou);
            this.Controls.Add(this.grpkuang);
            this.Controls.Add(this.rdonv);
            this.Controls.Add(this.rdonan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpkuang.ResumeLayout(false);
            this.grpkuang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdonan;
        private System.Windows.Forms.RadioButton rdonv;
        private System.Windows.Forms.CheckBox ceklan;
        private System.Windows.Forms.CheckBox cekzu;
        private System.Windows.Forms.CheckBox cekshu;
        private System.Windows.Forms.CheckBox cekyou;
        private System.Windows.Forms.GroupBox grpkuang;
        private System.Windows.Forms.Label lbltou;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtxin;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Label lblxin;
    }
}

